namespace LAB2
{
    partial class b6_l2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTenMonAn = new System.Windows.Forms.TextBox();
            this.pictureBoxHinhAnh = new System.Windows.Forms.PictureBox();
            this.textBoxNguoiNau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chọn Món";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTenMonAn
            // 
            this.textBoxTenMonAn.Location = new System.Drawing.Point(94, 364);
            this.textBoxTenMonAn.Name = "textBoxTenMonAn";
            this.textBoxTenMonAn.Size = new System.Drawing.Size(350, 22);
            this.textBoxTenMonAn.TabIndex = 1;
            // 
            // pictureBoxHinhAnh
            // 
            this.pictureBoxHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHinhAnh.Location = new System.Drawing.Point(319, 89);
            this.pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            this.pictureBoxHinhAnh.Size = new System.Drawing.Size(322, 254);
            this.pictureBoxHinhAnh.TabIndex = 2;
            this.pictureBoxHinhAnh.TabStop = false;
            // 
            // textBoxNguoiNau
            // 
            this.textBoxNguoiNau.Location = new System.Drawing.Point(547, 364);
            this.textBoxNguoiNau.Name = "textBoxNguoiNau";
            this.textBoxNguoiNau.Size = new System.Drawing.Size(346, 22);
            this.textBoxNguoiNau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Người nấu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(332, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hôm nay ăn gì";
            // 
            // b6_l2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB2.Properties.Resources.L6_2;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHinhAnh);
            this.Controls.Add(this.textBoxNguoiNau);
            this.Controls.Add(this.textBoxTenMonAn);
            this.Controls.Add(this.button1);
            this.Name = "b6_l2";
            this.Text = "b6_lab2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTenMonAn;
        private System.Windows.Forms.PictureBox pictureBoxHinhAnh;
        private System.Windows.Forms.TextBox textBoxNguoiNau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}