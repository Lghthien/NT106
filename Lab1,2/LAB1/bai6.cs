using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tinh_Click(object sender, EventArgs e)
        {

            int number1, number2;
            if (int.TryParse(A.Text, out number1) && int.TryParse(B.Text, out number2))
            {
                int soA = int.Parse(A.Text);
                int soB = int.Parse(B.Text);
                if (soA > soB)
                {
                    MessageBox.Show("Vui lòng nhập A < B");
                }
                else {
                    int hieu = soB - soA;
                    if (luachon.SelectedIndex == 0)
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            KQ.AppendText (hieu.ToString() + " * " + i.ToString() + " = " + (hieu*i).ToString() + Environment.NewLine);
                        }
                    }
                    else if(luachon.SelectedIndex == 1)
                    {
                        long gt = 1;
                        for (int i = 1;i <= hieu ; i++)
                        {
                            gt = gt * i;
                        }
                        KQ.AppendText(("(B - A)! =") + gt.ToString() + Environment.NewLine);
                        double tongmu = 0;
                        for (int i = 1; i <= soB; i++)
                        {
                            tongmu = tongmu + Math.Pow(soA, i);
                        }
                        KQ.AppendText( "A^1+A^2+...+A^B = "+ tongmu.ToString() +Environment.NewLine);
                    }
                }

               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại 2 số nguyên");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            A.Text = "";
            B.Text = "";
            KQ.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trang không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void kq_bt_Click(object sender, EventArgs e)
        {

        }

        private void nhapB_Click(object sender, EventArgs e)
        {

        }
    }
}
