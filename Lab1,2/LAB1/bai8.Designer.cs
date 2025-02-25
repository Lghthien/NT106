namespace bai1
{
    partial class bai8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tinh = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.nhap = new System.Windows.Forms.TextBox();
            this.xuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(1, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên sinh viên và danh sách điểm\r\nMỗi phần tử cách nhau \", \"\r\nví dụ: Nguyễ" +
    "n Văn A, 5, 6, 7, 8, 9";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tinh
            // 
            this.tinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh.ForeColor = System.Drawing.Color.Blue;
            this.tinh.Location = new System.Drawing.Point(678, 143);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(123, 58);
            this.tinh.TabIndex = 1;
            this.tinh.Text = "Tính";
            this.tinh.UseVisualStyleBackColor = false;
            this.tinh.Click += new System.EventHandler(this.tinh_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.ForeColor = System.Drawing.Color.Blue;
            this.xoa.Location = new System.Drawing.Point(678, 232);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(123, 58);
            this.xoa.TabIndex = 1;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.Color.Blue;
            this.thoat.Location = new System.Drawing.Point(678, 324);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(123, 58);
            this.thoat.TabIndex = 1;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(284, 106);
            this.nhap.Multiline = true;
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(388, 45);
            this.nhap.TabIndex = 3;
            // 
            // xuat
            // 
            this.xuat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.xuat.Enabled = false;
            this.xuat.Location = new System.Drawing.Point(16, 179);
            this.xuat.Multiline = true;
            this.xuat.Name = "xuat";
            this.xuat.Size = new System.Drawing.Size(656, 226);
            this.xuat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(132, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tính toán và xuất điểm học sinh";
            // 
            // bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bai1.Properties.Resources.tải_xuống__7_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xuat);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.tinh);
            this.Controls.Add(this.label1);
            this.Name = "bai8";
            this.Text = "bai8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tinh;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox nhap;
        private System.Windows.Forms.TextBox xuat;
        private System.Windows.Forms.Label label2;
    }
}