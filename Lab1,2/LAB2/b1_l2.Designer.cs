namespace LAB2
{
    partial class b1_l2
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
            this.read_tb = new System.Windows.Forms.Button();
            this.write_tb = new System.Windows.Forms.Button();
            this.output_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // read_tb
            // 
            this.read_tb.BackColor = System.Drawing.Color.Transparent;
            this.read_tb.FlatAppearance.BorderSize = 0;
            this.read_tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.read_tb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read_tb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.read_tb.Location = new System.Drawing.Point(52, 135);
            this.read_tb.Name = "read_tb";
            this.read_tb.Size = new System.Drawing.Size(202, 44);
            this.read_tb.TabIndex = 0;
            this.read_tb.Text = "Đọc file";
            this.read_tb.UseVisualStyleBackColor = false;
            this.read_tb.Click += new System.EventHandler(this.read_tb_Click);
            // 
            // write_tb
            // 
            this.write_tb.BackColor = System.Drawing.Color.Transparent;
            this.write_tb.FlatAppearance.BorderSize = 0;
            this.write_tb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.write_tb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write_tb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.write_tb.Location = new System.Drawing.Point(52, 217);
            this.write_tb.Name = "write_tb";
            this.write_tb.Size = new System.Drawing.Size(202, 44);
            this.write_tb.TabIndex = 0;
            this.write_tb.Text = "Ghi file";
            this.write_tb.UseVisualStyleBackColor = false;
            this.write_tb.Click += new System.EventHandler(this.write_tb_Click);
            // 
            // output_tb
            // 
            this.output_tb.BackColor = System.Drawing.SystemColors.Highlight;
            this.output_tb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_tb.ForeColor = System.Drawing.Color.White;
            this.output_tb.Location = new System.Drawing.Point(364, 152);
            this.output_tb.Multiline = true;
            this.output_tb.Name = "output_tb";
            this.output_tb.Size = new System.Drawing.Size(483, 234);
            this.output_tb.TabIndex = 1;
            this.output_tb.TextChanged += new System.EventHandler(this.output_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(325, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đọc và ghi file";
            // 
            // b1_l2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB2.Properties.Resources.bai1_l2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output_tb);
            this.Controls.Add(this.write_tb);
            this.Controls.Add(this.read_tb);
            this.DoubleBuffered = true;
            this.Name = "b1_l2";
            this.Text = "b1_l2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_tb;
        private System.Windows.Forms.Button write_tb;
        private System.Windows.Forms.TextBox output_tb;
        private System.Windows.Forms.Label label3;
    }
}