namespace bai1
{
    partial class bai9
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
            this.button1 = new System.Windows.Forms.Button();
            this.nhap = new System.Windows.Forms.TextBox();
            this.xem = new System.Windows.Forms.ListView();
            this.timlb = new System.Windows.Forms.Button();
            this.xoalb = new System.Windows.Forms.Button();
            this.thoatlb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(537, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(172, 55);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(359, 22);
            this.nhap.TabIndex = 2;
            // 
            // xem
            // 
            this.xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.xem.HideSelection = false;
            this.xem.Location = new System.Drawing.Point(30, 83);
            this.xem.Name = "xem";
            this.xem.Size = new System.Drawing.Size(588, 223);
            this.xem.TabIndex = 3;
            this.xem.UseCompatibleStateImageBehavior = false;
            this.xem.View = System.Windows.Forms.View.List;
            // 
            // timlb
            // 
            this.timlb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timlb.Location = new System.Drawing.Point(43, 312);
            this.timlb.Name = "timlb";
            this.timlb.Size = new System.Drawing.Size(163, 48);
            this.timlb.TabIndex = 1;
            this.timlb.Text = "Tìm món ăn";
            this.timlb.UseVisualStyleBackColor = false;
            this.timlb.Click += new System.EventHandler(this.timlb_Click);
            // 
            // xoalb
            // 
            this.xoalb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xoalb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoalb.Location = new System.Drawing.Point(290, 312);
            this.xoalb.Name = "xoalb";
            this.xoalb.Size = new System.Drawing.Size(86, 48);
            this.xoalb.TabIndex = 1;
            this.xoalb.Text = "Xóa";
            this.xoalb.UseVisualStyleBackColor = false;
            this.xoalb.Click += new System.EventHandler(this.xoalb_Click);
            // 
            // thoatlb
            // 
            this.thoatlb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.thoatlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatlb.Location = new System.Drawing.Point(483, 315);
            this.thoatlb.Name = "thoatlb";
            this.thoatlb.Size = new System.Drawing.Size(86, 48);
            this.thoatlb.TabIndex = 1;
            this.thoatlb.Text = "Thoát";
            this.thoatlb.UseVisualStyleBackColor = false;
            this.thoatlb.Click += new System.EventHandler(this.thoatlb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hôm nay ăn món :";
            // 
            // xuat
            // 
            this.xuat.Enabled = false;
            this.xuat.Location = new System.Drawing.Point(122, 407);
            this.xuat.Name = "xuat";
            this.xuat.Size = new System.Drawing.Size(391, 22);
            this.xuat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(219, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hôm nay ăn gì";
            // 
            // bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::bai1.Properties.Resources.tải_xuống__8_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xem);
            this.Controls.Add(this.xuat);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.thoatlb);
            this.Controls.Add(this.xoalb);
            this.Controls.Add(this.timlb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai9";
            this.Text = "bai9";
            this.Load += new System.EventHandler(this.bai9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nhap;
        private System.Windows.Forms.ListView xem;
        private System.Windows.Forms.Button timlb;
        private System.Windows.Forms.Button xoalb;
        private System.Windows.Forms.Button thoatlb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xuat;
        private System.Windows.Forms.Label label3;
    }
}