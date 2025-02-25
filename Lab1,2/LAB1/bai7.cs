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
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tim_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(nhap.Text, @"^(0?[1-9]|[12][0-9]|3[01])/(0?[1-9]|1[0-2])/\d{4}$"))
            {
                string[] parts = nhap.Text.Split('/');
                int ngay = int.Parse(parts[0]);
                int thang = int.Parse(parts[1]);
                int nam = int.Parse(parts[2]);
                if((thang == 12 && ngay >= 22) || (thang == 1 && ngay <= 20))
                    xuat.Text = "Ma Kết";
                else if((thang == 1 && ngay >= 21) || (thang == 2 && ngay <= 19))
                    xuat.Text = "Bảo Bình";
                else if((thang == 2 && ngay >= 20) || (thang == 3 && ngay <= 20))
                    xuat.Text = "Song Ngư";
                else if ((thang == 3 && ngay >= 21) || (thang == 4 && ngay <= 20))
                    xuat.Text = "Bạch Dương";
                else if ((thang == 4 && ngay >= 21) || (thang == 5 && ngay <= 21))
                    xuat.Text = "Kim Ngưu";
                else if((thang == 5 && ngay >= 22) || (thang == 6 && ngay <= 21))
                    xuat.Text = "Song Tử";
                else if((thang == 6 && ngay >= 22) || (thang == 7 && ngay <= 22))
                    xuat.Text = "Cự Giải";
                else if((thang == 7 && ngay >= 23) || (thang == 8 && ngay <= 22))
                    xuat.Text = "Sư Tử";
                else if((thang == 8 && ngay >= 23) || (thang == 9 && ngay <= 23))
                    xuat.Text = "Xử Nữ";
                else if((thang == 9 && ngay >= 24) || (thang == 10 && ngay <= 23))
                    xuat.Text = "Thiên Bình";
                else if((thang == 10 && ngay >= 24) || (thang == 11 && ngay <= 22))
                    xuat.Text = "Thần Nông";
                else if((thang == 11 && ngay >= 23) || (thang == 12 && ngay <= 21))
                    xuat.Text = "Nhân Mã";
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai ngày tháng năm hoặc định dạng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trang không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            nhap.Text = "";
            xuat.Text = "";
        }
    }
}
