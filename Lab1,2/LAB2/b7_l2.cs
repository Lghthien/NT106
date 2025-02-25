using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace LAB2
{
    public partial class b7_l2 : Form
    {
        public b7_l2()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void LoadDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory;
                danhsach_tv.Nodes.Add(driveNode);
                driveNode.Nodes.Add("");
            }
        }

        private void danhsach_tv_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                TreeNode currentNode = e.Node;
                currentNode.Nodes.Clear();

                DirectoryInfo currentDir = (DirectoryInfo)currentNode.Tag;
                foreach (DirectoryInfo dir in currentDir.GetDirectories())
                {
                    TreeNode dirNode = new TreeNode(dir.Name);
                    dirNode.Tag = dir;
                    dirNode.Nodes.Add(""); 
                    currentNode.Nodes.Add(dirNode);
                }

                foreach (FileInfo file in currentDir.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file;
                    currentNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void danhsach_tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentNode = e.Node;
            if (currentNode.Tag is DirectoryInfo)
            {
                danhsach_tv.SelectedNode = null; // Xóa lựa chọn hiện tại
                danhsach_tv.SelectedNode = currentNode; // Cập nhật lại lựa chọn
            }
            else if (currentNode.Tag is FileInfo)
            {
                DisplayFileContents((FileInfo)currentNode.Tag); // Hiển thị nội dung của tệp khi nhấp đúp vào
            }
        }

        private void DisplayFileContents(FileInfo file)
        {
            try
            {
                string extension = file.Extension.ToLower();
                if (IsTextFile(extension))
                {
                    output_tc.SelectedTab = Text_TC; 
                    textBox1.Text = File.ReadAllText(file.FullName); 
                }
                else if (IsImageFile(extension))
                {
                    output_tc.SelectedTab = Picture_TC;
                    pictureBox1.Image = System.Drawing.Image.FromFile(file.FullName);
                }
                else
                {
                    MessageBox.Show("Không hỗ trợ hiển thị nội dung của tệp này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsTextFile(string extension)
        {
            string[] textExtensions = { ".txt", ".csv", ".xml", ".html", ".css", ".cs", ".vb", ".java", ".cpp" };
            return Array.Exists(textExtensions, e => e == extension);
        }
        private bool IsImageFile(string extension)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return Array.Exists(imageExtensions, e => e == extension);
        }

        private void danhsach_tv_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentNode = e.Node;
            if (currentNode.Tag is DirectoryInfo)
            {
                danhsach_tv.SelectedNode = null;
                danhsach_tv.SelectedNode = currentNode; 
            }
            else if (currentNode.Tag is FileInfo)
            {
                DisplayFileContents((FileInfo)currentNode.Tag); 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
