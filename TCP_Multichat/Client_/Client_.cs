using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Client_
{
    public partial class Client_ : Form
    {
        IPEndPoint IP;
        Socket client = null;
        public Client_()
        {
            InitializeComponent();
            client = new Socket(SocketType.Stream, ProtocolType.Tcp);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }

        bool check_ip_port(string a, string b)
        {
            string pattern_ID = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            if (!Regex.IsMatch(a, pattern_ID))
            {
                return false;
            }
            string pattern_port = @"^(6553[0-5]|655[0-2]\d|65[0-4]\d{2}|6[0-4]\d{3}|[1-5]?\d{1,4})$";
            if (!Regex.IsMatch(b, pattern_port))
            {
                return false;
            }
            return true;
        }

        void Connect()
        {
            if (check_ip_port(inputIP.Text, inputPort.Text))
            {
                try
                {
                    IPAddress serverIp = IPAddress.Parse(inputIP.Text);
                    int serverPort = int.Parse(inputPort.Text);
                    IP = new IPEndPoint(serverIp, serverPort);
                    client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    client.Connect(IP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
                MessageBox.Show("Đã kết nối với Server", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Vui lòng nhập lại IP hoặc port", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void Disconnect()
        {
            client.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (txtMessage.Text != "")
            {
                client.Send(Serialize(guestName.Text + ": " + txtMessage.Text));
                Message_Add(guestName.Text + ": " + txtMessage.Text);
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string receivedMessage = (string)Deserialize(data);
                    string displayedMessage = receivedMessage;
                    Message_Add(displayedMessage);
                }
            }
            catch
            {
                Disconnect();
            }
        }

        void Message_Add(string message)
        {
            if (messageLv.InvokeRequired)
            {
                messageLv.Invoke(new Action<string>(Message_Add), new object[] { message });
            }
            else
            {
                messageLv.Items.Add(new ListViewItem() { Text = DateTime.Now.ToString("HH:mm:ss") + " -  " + message });
            }
            txtMessage.Clear();
        }

        byte[] Serialize(object send)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, send);

            return stream.ToArray();
        }

        object Deserialize(byte[] receive)
        {
            MemoryStream stream = new MemoryStream(receive);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}