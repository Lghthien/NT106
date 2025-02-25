using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace bai1
{
    public class Phim
    {
        [JsonPropertyName("TenPhim")]
        public string Ten { get; set; }

        [JsonPropertyName("GiaVeChuan")]
        public int GiaVe { get; set; }

        [JsonPropertyName("PhongChieu")]
        public int[] PhongChieu { get; set; }
    }

    public partial class b5_l2 : Form
    {
        
        public b5_l2()
        {
            InitializeComponent();
            List<Phim> phims = new List<Phim>();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Json|*.json";
            open.ShowDialog();
            FileStream fileStream = new FileStream(open.FileName, FileMode.Open);
            phims = JsonSerializer.Deserialize<List<Phim>>(fileStream);
            phim.DataSource = phims;
            phim.DisplayMember = "Ten";
        }

        private void A1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dat_bt_Click(object sender, EventArgs e)
        {
            string ten = nhap.Text;
            xuat.Items.Add(new ListViewItem("Họ và tên: " + ten + "\n"));

            string phim = this.phim.SelectedItem.ToString();
            xuat.Items.Add(new ListViewItem("Tên phim, giá vé, phòng chiếu: " + phim + "\n"));

            int giave;
            double tong = 0;

            if (this.phim.SelectedIndex == 0 || this.phim.SelectedIndex == 1 || this.phim.SelectedIndex == 2)
            {
                giave = 45000;
            }
            else if (this.phim.SelectedIndex == 3 || this.phim.TabIndex == 4)
            {
                giave = 100000;
            }
            else if (this.phim.SelectedIndex == 5)
            {
                giave = 70000;
            }
            else
            {
                giave = 90000;
            }

            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            xuat.Items.Add(new ListViewItem("Vé đã đặt"));
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    if ((checkBox.Name == "A1" || checkBox.Name == "A5" || checkBox.Name == "B1" || checkBox.Name == "B5" || checkBox.Name == "C1" || checkBox.Name == "C5"))
                    {
                        tong += 0.25 * giave;
                        xuat.Items.Add(new ListViewItem(checkBox.Name));
                        checkBox.Enabled = false;
                    }
                    else if (checkBox.Name == "A2" || checkBox.Name == "A4" || checkBox.Name == "B2" || checkBox.Name == "B4" || checkBox.Name == "C2" || checkBox.Name == "C4")
                    {
                        tong += 1 * giave;
                        xuat.Items.Add(new ListViewItem(checkBox.Name));
                        checkBox.Enabled = false;
                    }
                    else
                    {
                        tong += 2 * giave;
                        xuat.Items.Add(new ListViewItem(checkBox.Name));
                        checkBox.Enabled = false;
                    }
                }
            }

            xuat.Items.Add(new ListViewItem("Số tiền cần phải thanh toán: " + tong + "\n"));
        }

        private void xuat_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tenphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phim selectedPhim = phim.SelectedItem as Phim;
            phong.DataSource = selectedPhim.PhongChieu;
            label5.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe;
        }

        private void b5_l2_Load(object sender, EventArgs e)
        {
            Phim selectedPhim = phim.SelectedItem as Phim;
        }
    }
}
