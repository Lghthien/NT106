using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhap.Text = "";
            xuat.Text = "";
        }


        private void them_Click(object sender, EventArgs e)
        {

        }
        private void doc_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(nhap.Text, @"^[0-9]$"))
            {
                int so = int.Parse(nhap.Text);
                switch(so)
                {
                    case 0:
                        {
                            xuat.Text = "Không";
                            break;
                        }
                    case 1:
                        {
                            xuat.Text = "Một";
                            break;
                        }
                    case 2:
                        {
                            xuat.Text = "Hai";
                            break;
                        }
                    case 3:
                        {
                            xuat.Text = "Ba";
                            break;
                        }
                    case 4:
                        {
                            xuat.Text = "Bốn";
                            break;
                        }
                    case 5:
                        {
                            xuat.Text = "Năm";
                            break;
                        }
                    case 6:
                        {
                            xuat.Text = "Sáu";
                            break;
                        }
                    case 7:
                        {
                            xuat.Text = "Bảy";
                            break;
                        }
                    case 8:
                        {
                            xuat.Text = "Tám";
                            break;
                        }
                    case 9:
                        {
                            xuat.Text = "Chín";
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại 1 số từ 0->9");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trang không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
