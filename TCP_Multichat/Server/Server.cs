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

namespace Server
{
    public partial class Server : Form
    {
        IPEndPoint IP;
        Socket server = null;
        List<Socket> clientList;

        public Server()
        {
            InitializeComponent();
            server = new Socket(SocketType.Stream, ProtocolType.Tcp);
            CheckForIllegalCrossThreadCalls = false;
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
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Close();
        }

        void Connect()
        {
            if (check_ip_port(inputIP.Text, inputPort.Text))
            {
                clientList = new List<Socket>();
                IP = new IPEndPoint(IPAddress.Parse(inputIP.Text), int.Parse(inputPort.Text));
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                server.Bind(IP);

                Thread listen = new Thread(() => {
                    try
                    {
                        while (true)
                        {
                            server.Listen(100);
                            Socket client = server.Accept();
                            clientList.Add(client);

                            Thread receive = new Thread(Receive);
                            receive.IsBackground = true;
                            receive.Start(client);
                        }
                    }
                    catch
                    {
                        IP = new IPEndPoint(IPAddress.Parse(inputIP.Text), int.Parse(inputPort.Text));
                        server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    }
                });
                listen.IsBackground = true;
                listen.Start();
                MessageBox.Show("Server đã mở kết nối", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Vui lòng nhập lại IP hoặc port", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void Disconnect()
        {
            server.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send(item);
            }
            Message_Add(serverName.Text + ": " + txtMessage.Text);
            txtMessage.Clear();
        }

        void Send(Socket client)
        {
            if (client != null && txtMessage.Text != "")
                client.Send(Serialize(serverName.Text + ": " + txtMessage.Text));
        }

        void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string receivedMessage = (string)Deserialize(data);
                    string displayedMessage = receivedMessage;
                    Message_Add(displayedMessage);

                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                            item.Send(Serialize(displayedMessage));
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
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

        private void listen_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}