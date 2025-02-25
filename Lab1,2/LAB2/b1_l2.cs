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
using System.Windows.Forms.VisualStyles;

namespace LAB2
{
    public partial class b1_l2 : Form
    {
        public b1_l2()
        {
            InitializeComponent();
        }

        private void read_tb_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader streamReader = new StreamReader(fs);
                output_tb.Text = streamReader.ReadToEnd();
                streamReader.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file đầu vào để đọc!");
            }
        }

        private void output_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void write_tb_Click(object sender, EventArgs e)
        {   
            OpenFileDialog inputFileDialog = new OpenFileDialog();
            if (inputFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputPath = inputFileDialog.FileName;

                OpenFileDialog outputFileDialog = new OpenFileDialog();
                if (outputFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = outputFileDialog.FileName;

                    try
                    {
                        string text = File.ReadAllText(inputPath);

                        text = text.ToUpper();

                        File.WriteAllText(outputPath, "");

                        File.WriteAllText(outputPath, text);

                        MessageBox.Show("Nội dung đã được chuyển thành chữ hoa và lưu vào file: " + outputPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi chuyển đổi file: " + ex.Message);
                    }
                }
                else
                { 
                    MessageBox.Show("Vui lòng chọn file đầu ra để lưu nội dung!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file đầu vào để chuyển đổi!");
            }
        }
    }
}
