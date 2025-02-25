using bai1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class lab2 : Form
    {
        public lab2()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            b1_l2 b1 = new b1_l2();
            b1.ShowDialog();
        }
        private void bai2_Click(object sender, EventArgs e)
        {
            b2_l2 b2 = new b2_l2(); 
            b2.ShowDialog();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            b3_l2 b3 = new b3_l2(); 
            b3.ShowDialog();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
            b4_l2 b4 = new b4_l2();
            b4.ShowDialog();
        }

        private void bai5_Click(object sender, EventArgs e)
        {
            b7_l2 b7 = new b7_l2();
            b7.ShowDialog();
        }

        private void bai6_Click(object sender, EventArgs e)
        {
            b6_l2 b6 = new b6_l2();
            b6.ShowDialog();
        }

        private void bai7_Click(object sender, EventArgs e)
        {
            b5_l2 b5 = new b5_l2();
            b5.ShowDialog();
        }

    }
}
