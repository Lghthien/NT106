using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB2
{
    public partial class b4_l2 : Form
    {
        private List<HocSinh> danhSachHocSinh;
        public b4_l2()
        {
            InitializeComponent();
            danhSachHocSinh = new List<HocSinh>();

        }

       public class HocSinh
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Phone { get; set; }
            public string Course1 { get; set; }
            public string Course2 { get; set; }
            public string Course3 { get; set; }
            public string Average { get; set; }

            // Phương thức (constructor)
            public HocSinh(string name, string id, string phone, string course1, string course2, string course3)
            {
                Name = name;
                ID = id;
                Phone = phone;
                Course1 = course1;
                Course2 = course2;
                Course3 = course3;
                Average = CalculateAverage().ToString("0.00");
            }
            private double CalculateAverage()
            {
                double totalScore = 0;
                totalScore = (double.Parse(Course1) + double.Parse(Course2) + double.Parse(Course3))/3;
                return totalScore;

            }
        }
        string URL;
        string URL1;
        private void write_bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng chọn file ghi");
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                    
                URL = ofd.FileName;
                MessageBox.Show("Vui lòng chọn file sẽ tính điểm trung bình");
                OpenFileDialog os = new OpenFileDialog();
                if (os.ShowDialog() == DialogResult.OK)
                {
                    URL1 = os.FileName;
                    using (FileStream fs = new FileStream(URL, FileMode.Open))
                    using (StreamReader streamReader = new StreamReader(fs))
                    {
                        string text = streamReader.ReadToEnd();
                        output_lb.Text = text;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file đầu vào để đọc!");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn file đầu vào để đọc!");
            }
        }

        private void input_bt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(in_name_tb.Text) ||
        string.IsNullOrEmpty(in_ID_tb.Text) ||
        string.IsNullOrEmpty(in_Phone_tb.Text) ||
        string.IsNullOrEmpty(in_1_tb.Text) ||
        string.IsNullOrEmpty(in_2_tb.Text) ||
        string.IsNullOrEmpty(in_3_tb.Text))
            {
                MessageBox.Show("Hãy điền hết thông tin");
                return; 
            }
                string idPattern = "^\\d{8}$"; // 8 chữ số
                string phonePattern = "^0\\d{9}$"; // 10 chữ số bắt đầu bằng số 0
                string coursePattern = "^(?:[0-9]|10)(?:\\.[0-9]{1,2})?$"; //các số thực từ 0 đến 10 sau dấu . 2 chữ số 

     
                if (!Regex.IsMatch(in_ID_tb.Text, idPattern))
                {
                    MessageBox.Show("ID có 8 chữ số");
                    return;
                }

                if (!Regex.IsMatch(in_Phone_tb.Text, phonePattern))
                {
                    MessageBox.Show("Phone có 10 chữ số bắt đầu bằng số 0");
                    return;
                }

                if (!Regex.IsMatch(in_1_tb.Text, coursePattern) ||
                    !Regex.IsMatch(in_2_tb.Text, coursePattern) ||
                    !Regex.IsMatch(in_3_tb.Text, coursePattern))
                {
                    MessageBox.Show("Điểm là các số thực từ 0 đến 10 sau dấu . 2 chữ số ");
                    return;
                }

            HocSinh hocSinh = new HocSinh(
                in_name_tb.Text,
                in_ID_tb.Text, 
                in_Phone_tb.Text,
                in_1_tb.Text,
                in_2_tb.Text,
                in_3_tb.Text
            );

           

            try
            {
                using (StreamWriter writer = new StreamWriter(URL, true))
                {
                    string formattedData = string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n",
                                                       hocSinh.Name, hocSinh.ID, hocSinh.Phone,
                                                       hocSinh.Course1, hocSinh.Course2, hocSinh.Course3);
                    writer.WriteLine(formattedData);
                }
                using (StreamWriter writer = new StreamWriter(URL1,true))
                {
                    string formattedData = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                                                       hocSinh.Name, hocSinh.ID, hocSinh.Phone,
                                                       hocSinh.Course1, hocSinh.Course2, hocSinh.Course3,
                                                       hocSinh.Average);
                    writer.WriteLine(formattedData);
                }
                in_name_tb.Text = "";
                in_ID_tb.Text = "";
                in_Phone_tb.Text = "";
                in_1_tb.Text = "";
                in_2_tb.Text = "";
                in_3_tb.Text = "";
                MessageBox.Show("Thêm học sinh thành công"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm học sinh thất bại " + ex.Message); 
            }

            using (FileStream fs = new FileStream(URL, FileMode.Open))
            using (StreamReader streamReader = new StreamReader(fs))
            {
                string text = streamReader.ReadToEnd();
                output_lb.Text = text;
            }

        }

        private void read_bt_Click(object sender, EventArgs e)
        {  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadStudentList(filePath);
            }

        }
        private void LoadStudentList(string filePath)
        {
            try
            {
                danhSachHocSinh.Clear(); 

                string[] lines = File.ReadAllLines(filePath); 
                foreach (string line in lines)
                {
                    string[] items = line.Split(','); 
                    if (items.Length == 7) 
                    {
                        HocSinh hocSinh = new HocSinh(items[0], items[1], items[2], items[3], items[4], items[5]);
                        danhSachHocSinh.Add(hocSinh); 
                    }
                }

                if (danhSachHocSinh.Count > 0)
                {
                    currentIndex = 0; 
                    DisplayCurrentStudent(); 
                }
                else
                {
                    MessageBox.Show("Không có học sinh nào được tìm thấy trong tệp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void DisplayCurrentStudent()
        {
            HocSinh currentStudent = danhSachHocSinh[currentIndex];
 
            out_Name_tb.Text = currentStudent.Name;
            out_ID_tb.Text = currentStudent.ID;
            out_Phone_tb.Text = currentStudent.Phone;
            out_1_tb.Text = currentStudent.Course1;
            out_2_tb.Text = currentStudent.Course2;
            out_3_tb.Text = currentStudent.Course3;
            out_A_tb.Text = currentStudent.Average;
        }

        private int currentIndex = 0;

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
               
                currentIndex--;
                so_lb.Text = (currentIndex + 1).ToString();
                DisplayCurrentStudent();
            }
            else
            {
                MessageBox.Show("Đã đến học sinh đầu danh sách.");
            }
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {

            if (currentIndex < danhSachHocSinh.Count - 1)
            {
                
                currentIndex++;
                so_lb.Text = (currentIndex + 1).ToString();
                DisplayCurrentStudent();
            }
            else
            {
                MessageBox.Show("Đã đến học sinh cuối danh sách.");
            }
        }
    }
}

