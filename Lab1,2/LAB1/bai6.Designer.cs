namespace bai1
{
    partial class bai6
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
            this.components = new System.ComponentModel.Container();
            this.nhapA = new System.Windows.Forms.Label();
            this.nhapB = new System.Windows.Forms.Label();
            this.kq_bt = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.luachon = new System.Windows.Forms.ComboBox();
            this.tinh = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.KQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nhapA
            // 
            this.nhapA.AutoSize = true;
            this.nhapA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapA.Location = new System.Drawing.Point(12, 89);
            this.nhapA.Name = "nhapA";
            this.nhapA.Size = new System.Drawing.Size(78, 25);
            this.nhapA.TabIndex = 0;
            this.nhapA.Text = "Nhập A";
            // 
            // nhapB
            // 
            this.nhapB.AutoSize = true;
            this.nhapB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapB.Location = new System.Drawing.Point(520, 93);
            this.nhapB.Name = "nhapB";
            this.nhapB.Size = new System.Drawing.Size(77, 25);
            this.nhapB.TabIndex = 1;
            this.nhapB.Text = "Nhập B";
            this.nhapB.Click += new System.EventHandler(this.nhapB_Click);
            // 
            // kq_bt
            // 
            this.kq_bt.AutoSize = true;
            this.kq_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kq_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kq_bt.Location = new System.Drawing.Point(322, 222);
            this.kq_bt.Name = "kq_bt";
            this.kq_bt.Size = new System.Drawing.Size(92, 26);
            this.kq_bt.TabIndex = 0;
            this.kq_bt.Text = "Kết Quả";
            this.kq_bt.Click += new System.EventHandler(this.kq_bt_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(100, 89);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(132, 22);
            this.A.TabIndex = 2;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(608, 93);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(132, 22);
            this.B.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // luachon
            // 
            this.luachon.FormattingEnabled = true;
            this.luachon.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.luachon.Location = new System.Drawing.Point(265, 133);
            this.luachon.Name = "luachon";
            this.luachon.Size = new System.Drawing.Size(214, 24);
            this.luachon.TabIndex = 4;
            this.luachon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tinh
            // 
            this.tinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tinh.Location = new System.Drawing.Point(72, 163);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(160, 47);
            this.tinh.TabIndex = 5;
            this.tinh.Text = "Tính các giá trị";
            this.tinh.UseVisualStyleBackColor = false;
            this.tinh.Click += new System.EventHandler(this.tinh_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xoa.Location = new System.Drawing.Point(294, 163);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(160, 47);
            this.xoa.TabIndex = 5;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.thoat.Location = new System.Drawing.Point(525, 163);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(160, 47);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // KQ
            // 
            this.KQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.KQ.Enabled = false;
            this.KQ.Location = new System.Drawing.Point(141, 254);
            this.KQ.Multiline = true;
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(469, 173);
            this.KQ.TabIndex = 6;
            this.KQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "In bảng cửu chương hoặc tính toán giá trị";
            // 
            // bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bai1.Properties.Resources.tải_xuống__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.tinh);
            this.Controls.Add(this.luachon);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.nhapB);
            this.Controls.Add(this.kq_bt);
            this.Controls.Add(this.nhapA);
            this.Name = "bai6";
            this.Text = "bai6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nhapA;
        private System.Windows.Forms.Label nhapB;
        private System.Windows.Forms.Label kq_bt;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox luachon;
        private System.Windows.Forms.Button tinh;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox KQ;
        private System.Windows.Forms.Label label1;
    }
}