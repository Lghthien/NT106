using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai1
{
    public partial class bai9 : Form
    {
        public bai9()
        {
            InitializeComponent();
        }

        private void bai9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string monan = nhap.Text;
            xem.Items.Add(new ListViewItem (monan + "\n"));
        }

        private void timlb_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int selectedIndex = random.Next(0, xem.Items.Count);
            string selectedItemText = xem.Items[selectedIndex].Text;
            xuat.Text = selectedItemText;
        }

        private void xoalb_Click(object sender, EventArgs e)
        {
            nhap.Text = "";
            xuat.Text = "";
            xem.Items.Clear();
        }

        private void thoatlb_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trang không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
