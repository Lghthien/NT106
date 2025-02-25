using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class b2_l2 : Form
    {
        public b2_l2()
        {
            InitializeComponent();
        }

        private void read_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename_tb.Text = ofd.SafeFileName.ToString();

                FileInfo fileInfo = new FileInfo(ofd.FileName);
                long fileSize = fileInfo.Length;
                size_tb.Text = fileSize.ToString() + " bytes";

                URL_tb.Text = ofd.FileName;

          
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(fs))
                {
                    string text = streamReader.ReadToEnd();

                    int lineCount = text.Split('\n').Length; 
                    lineCount_tb.Text = lineCount.ToString();

                    string[] words = text.Split(' ');
                    int wordCount = words.Length;
                    words_tb.Text = wordCount.ToString();

                    int charCount = text.Length;
                    Character_tb.Text = charCount.ToString();

                    output_tb.Text = text;
                } 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file đầu vào để đọc!");
            }
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trang không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
