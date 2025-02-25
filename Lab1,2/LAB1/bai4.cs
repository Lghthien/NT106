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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        static string SoVietTat(string so)
        {
            switch (so)
            {
                //case "0": return "Không";
                case "1": return "Một";
                case "2": return "Hai";
                case "3": return "Ba";
                case "4": return "Bốn";
                case "5": return "Năm";
                case "6": return "Sáu";
                case "7": return "Bảy";
                case "8": return "Tám";
                case "9": return "Chín";
                default: return ""; // Trường hợp số không nằm trong khoảng từ 1 đến 9
            }
        }

        static string DocSoTiengViet(string soStr)
        {
            int so = int.Parse(soStr);

            string[] donVi = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] donViHangChuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] donViHangTram = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };

            string docSo = "";

            int tram = so / 100;
            int chuc = (so % 100) / 10;
            int donvi = so % 10;

            docSo += donViHangTram[tram];

            if (chuc == 0 && donvi == 0)
            {
                // Không cần làm gì cả
            }
            else if (chuc == 0)
            {
                docSo += "không trăm linh " + donVi[donvi];
            }
            else if (chuc == 1 && donvi == 5)
            {
                docSo += " " + donViHangChuc[chuc] + " lăm" ;
            }
            else if (chuc == 1)
            {
                docSo += " " + donViHangChuc[chuc] + " " + donVi[donvi];
            }
            else
            {
                docSo += " " + donViHangChuc[chuc];
                if (donvi != 0)
                {
                    docSo += " " + donVi[donvi];
                }
            }

            return docSo.Trim();
        }
        private void doc_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(nhap.Text, @"^\d{1,12}$"))
            {
                string so = nhap.Text;
                so = so.PadLeft(12, '0');
                //xuat.Text = so;
                string ty = so.Substring(0, 3);
                string trieu = so.Substring(3, 3);
                string nghin = so.Substring(6, 3);
                string tram = so.Substring(9, 3);
                if(nghin == "000" && trieu == "000" && ty == "000")
                {
                    xuat.Text = DocSoTiengViet(tram);
                }
                else if (trieu == "000" && ty == "000")
                {
                    xuat.Text = DocSoTiengViet(nghin) + " Nghìn " + DocSoTiengViet(tram);
                }
                else if (ty == "000")
                {
                    if (nghin == "000")
                    {
                        xuat.Text = DocSoTiengViet(trieu) + " Triệu " + DocSoTiengViet(tram);
                    }
                    else
                    {
                        xuat.Text = DocSoTiengViet(trieu) + " Triệu " + DocSoTiengViet(nghin) + " Nghìn " + DocSoTiengViet(tram);
                    }
                }
                else
                {   
                    if (trieu == "000" && nghin == "000")
                    {
                        xuat.Text = DocSoTiengViet(ty) + " Tỷ " + DocSoTiengViet(tram);
                    }
                    else if (nghin == "000")
                    {
                        xuat.Text = DocSoTiengViet(ty) + " Tỷ " + DocSoTiengViet(trieu) + " Triệu " + DocSoTiengViet(tram);
                    }
                    else if (trieu == "000")
                    {
                        xuat.Text = DocSoTiengViet(ty) + " Tỷ " + DocSoTiengViet(nghin) + " Nghìn " + DocSoTiengViet(tram);
                    }
                    else
                    {
                        xuat.Text = DocSoTiengViet(ty) + " Tỷ " + DocSoTiengViet(trieu) + " Triệu " + DocSoTiengViet(nghin) + " Nghìn " + DocSoTiengViet(tram);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại theo yêu cầu");
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
