using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tinh_Click(object sender, EventArgs e)
        {
            string input = nhap.Text;
            if (Regex.IsMatch(nhap.Text, @"^[\p{L}\s]+(?:, (?:10|\b[0-9]\b))+$"))
            {
                string[] parts = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                xuat.Text += string.Format("Họ và Tên : {0}", parts[0]);
                xuat.Text += Environment.NewLine;
                int n = parts.Length;
                for (int i = 1; i < n; i++)
                {
                    xuat.Text += string.Format("Môn {0} : {1} đ, ", i , parts[i]);
                }
                xuat.Text += Environment.NewLine; 

                int[] sodiem = new int[n - 1];
                for (int i = 1; i < n; i++)
                {
                    sodiem[i-1] = int.Parse(parts[i]);
                }
                xuat.Text += string.Format("Số điểm lớn nhất : {0} , Số điểm bé nhất : {1} , Số điểm trung bình : {2} .", sodiem.Max(), sodiem.Min(), sodiem.Average());
                xuat.Text += Environment.NewLine;
                if(sodiem.Average()>=8 && sodiem.Min() >= 6.5)
                {
                    xuat.Text += "Xếp loại Giỏi";
                }
                else if(sodiem.Average() >= 6.5 && sodiem.Min() >= 5)
                {
                    xuat.Text += "Xếp loại Khá";
                }
                else if(sodiem.Average() >= 5 && sodiem.Min() >= 3.5)
                {
                    xuat.Text += "Xếp loại Trung bình";
                }
                else if(sodiem.Average() >= 3.5 && sodiem.Min() >= 2)
                {
                    xuat.Text += "Xếp loại Yếu";
                }
                else
                {
                    xuat.Text += "Xếp loại Kém";
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại theo định dạng");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            nhap.Text = "";
            xuat.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trang không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
