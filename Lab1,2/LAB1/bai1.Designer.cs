namespace bai1
{
    partial class bai1
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
            this.sothu1 = new System.Windows.Forms.Label();
            this.so1 = new System.Windows.Forms.TextBox();
            this.tinhtong = new System.Windows.Forms.Button();
            this.tong = new System.Windows.Forms.Label();
            this.sothu2 = new System.Windows.Forms.Label();
            this.so2 = new System.Windows.Forms.TextBox();
            this.tong2so = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sothu1
            // 
            this.sothu1.AutoSize = true;
            this.sothu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sothu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothu1.Location = new System.Drawing.Point(202, 132);
            this.sothu1.Name = "sothu1";
            this.sothu1.Size = new System.Drawing.Size(112, 25);
            this.sothu1.TabIndex = 0;
            this.sothu1.Text = "Số thứ nhất";
            this.sothu1.Click += new System.EventHandler(this.label1_Click);
            // 
            // so1
            // 
            this.so1.Location = new System.Drawing.Point(185, 160);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(145, 22);
            this.so1.TabIndex = 2;
            // 
            // tinhtong
            // 
            this.tinhtong.BackColor = System.Drawing.Color.Cyan;
            this.tinhtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtong.Location = new System.Drawing.Point(238, 323);
            this.tinhtong.Name = "tinhtong";
            this.tinhtong.Size = new System.Drawing.Size(105, 55);
            this.tinhtong.TabIndex = 3;
            this.tinhtong.Text = "Tính";
            this.tinhtong.UseVisualStyleBackColor = false;
            this.tinhtong.Click += new System.EventHandler(this.tinhtong_Click);
            // 
            // tong
            // 
            this.tong.AutoSize = true;
            this.tong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong.Location = new System.Drawing.Point(342, 242);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(115, 25);
            this.tong.TabIndex = 0;
            this.tong.Text = "Tổng hai số";
            this.tong.Click += new System.EventHandler(this.label3_Click);
            // 
            // sothu2
            // 
            this.sothu2.AutoSize = true;
            this.sothu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sothu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothu2.Location = new System.Drawing.Point(476, 132);
            this.sothu2.Name = "sothu2";
            this.sothu2.Size = new System.Drawing.Size(100, 25);
            this.sothu2.TabIndex = 0;
            this.sothu2.Text = "Số thứ hai";
            this.sothu2.Click += new System.EventHandler(this.label1_Click);
            // 
            // so2
            // 
            this.so2.Location = new System.Drawing.Point(450, 160);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(145, 22);
            this.so2.TabIndex = 2;
            // 
            // tong2so
            // 
            this.tong2so.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tong2so.Enabled = false;
            this.tong2so.ForeColor = System.Drawing.Color.White;
            this.tong2so.Location = new System.Drawing.Point(326, 270);
            this.tong2so.Name = "tong2so";
            this.tong2so.ReadOnly = true;
            this.tong2so.Size = new System.Drawing.Size(145, 22);
            this.tong2so.TabIndex = 2;
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.Cyan;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(436, 323);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(105, 55);
            this.thoat.TabIndex = 4;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(271, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tính tổng hai số";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bai1.Properties.Resources.tải_xuống__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tinhtong);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.tong2so);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.sothu2);
            this.Controls.Add(this.sothu1);
            this.DoubleBuffered = true;
            this.Name = "bai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sothu1;
        private System.Windows.Forms.TextBox so1;
        private System.Windows.Forms.Button tinhtong;
        private System.Windows.Forms.Label tong;
        private System.Windows.Forms.Label sothu2;
        private System.Windows.Forms.TextBox so2;
        private System.Windows.Forms.TextBox tong2so;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label1;
    }
}

