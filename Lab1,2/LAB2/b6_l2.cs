using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
namespace LAB2
{
    public partial class b6_l2 : Form
    {
        public b6_l2()
        {
            CleanUpDatabase();
            InitializeDatabase();
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        static void InitializeDatabase()
        {
            string dbFilePath = "Monan.db";

            // Tạo kết nối tới cơ sở dữ liệu SQLite
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                // Tạo bảng MonAn
                string createMonAnTable = "CREATE TABLE IF NOT EXISTS MonAn (IDMA INTEGER PRIMARY KEY AUTOINCREMENT, TenMonAn TEXT, HinhAnh TEXT, IDNCC INTEGER)";
                using (SQLiteCommand command = new SQLiteCommand(createMonAnTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Tạo bảng NguoiDung
                string createNguoiDungTable = "CREATE TABLE IF NOT EXISTS NguoiDung (IDNCC INTEGER PRIMARY KEY AUTOINCREMENT, HoVaTen TEXT, QuyenHan TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createNguoiDungTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Nhập dữ liệu mẫu vào bảng MonAn
                string insertMonAnData = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Pho', 'pho.jpg', 1), ('Banh mi', 'banhmi.jpg', 2),('Bun cha', 'buncha.jpg', 1)";
                using (SQLiteCommand command = new SQLiteCommand(insertMonAnData, connection))
                {
                    command.ExecuteNonQuery();
                }

                string insertNguoiDungnData = "INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES (1, 'NguyenVanA', 'Bep truong'), (2, 'TranVanB', 'PhuBep')";
                using (SQLiteCommand command = new SQLiteCommand(insertNguoiDungnData, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        static void CleanUpDatabase()
        {
            string dbFilePath = "Monan.db";

            // Tạo kết nối tới cơ sở dữ liệu SQLite
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                // Xóa toàn bộ dữ liệu từ tất cả các bảng
                string deleteAllData = "DELETE FROM MonAn; DELETE FROM NguoiDung;";
                using (SQLiteCommand command = new SQLiteCommand(deleteAllData, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private SQLiteConnection connection;
        private void InitializeDatabaseConnection()
        {
            string dbFilePath = "Monan.db";
            connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");
            connection.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MonAn ORDER BY RANDOM() LIMIT 1";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int monAnID = reader.GetInt32(reader.GetOrdinal("IDMA"));
                        string tenMonAn = reader.GetString(reader.GetOrdinal("TenMonAn"));
                        string hinhAnh = reader.GetString(reader.GetOrdinal("HinhAnh"));
                        int nguoiDungID = reader.GetInt32(reader.GetOrdinal("IDNCC"));

                        string nguoiNau = GetNguoiNau(nguoiDungID);

                        textBoxTenMonAn.Text = tenMonAn;
                        textBoxNguoiNau.Text = nguoiNau;

                        // Lấy đường dẫn đến thư mục chứa hình ảnh của món ăn
                        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                        string imagePath = Path.Combine(projectDirectory, "Image", hinhAnh);

                        try
                        {
                            if (File.Exists(imagePath))
                            {
                                pictureBoxHinhAnh.Image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                MessageBox.Show($"File not found: {imagePath}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}");
                        }
                    }
                }
            }
        }
        private string GetNguoiNau(int nguoiDungID)
        {
            string query = $"SELECT HoVaTen FROM NguoiDung WHERE IDNCC = {nguoiDungID}";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                return command.ExecuteScalar()?.ToString();
            }
        }


    }
}
