using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace bai1
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        static void swap( int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void timso_Click(object sender, EventArgs e)
        {
            
            int sothunhat, sothuhai, sothuba;
            if (int.TryParse(so1.Text, out sothunhat) && int.TryParse(so2.Text, out sothuhai) && int.TryParse(so3.Text, out sothuba))
            {
                int min = Math.Min(Math.Min(sothunhat, sothuhai), sothuba);
                int max = Math.Max(Math.Max(sothunhat, sothuhai), sothuba);

                kqsln.Text = max.ToString();
                kqsnn.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại 3 số nguyên");
            }
        }

        private void kqsln_TextChanged(object sender, EventArgs e)
        {

        }

        private void xoaso_Click(object sender, EventArgs e)
        {
            so1.Text = "";
            so2.Text = "";
            so3.Text = "";
            kqsln.Text = "";
            kqsnn.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trang không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
