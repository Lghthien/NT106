using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace bai1
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tinhtong_Click(object sender, EventArgs e)
        {

            int number1,number2;
            if (int.TryParse(so1.Text, out number1) && int.TryParse(so2.Text,out number2 ))
            {
                int sothunhat = int.Parse(so1.Text);
                int sothuhai = int.Parse(so2.Text);
                tong2so.Text = (sothunhat + sothuhai).ToString();
            }
            else
            {
                 MessageBox.Show("Vui lòng nhập lại 2 số nguyên");
            }
            
        
        }

        private void bai1_Load(object sender, EventArgs e)
        {

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
