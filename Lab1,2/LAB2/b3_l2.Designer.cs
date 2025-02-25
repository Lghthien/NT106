namespace LAB2
{
    partial class b3_l2
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
            this.input_tb = new System.Windows.Forms.TextBox();
            this.output_lb = new System.Windows.Forms.TextBox();
            this.tinh_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_tb
            // 
            this.input_tb.Location = new System.Drawing.Point(49, 158);
            this.input_tb.Multiline = true;
            this.input_tb.Name = "input_tb";
            this.input_tb.Size = new System.Drawing.Size(381, 205);
            this.input_tb.TabIndex = 0;
            this.input_tb.TextChanged += new System.EventHandler(this.input_tb_TextChanged);
            // 
            // output_lb
            // 
            this.output_lb.Enabled = false;
            this.output_lb.Location = new System.Drawing.Point(522, 158);
            this.output_lb.Multiline = true;
            this.output_lb.Name = "output_lb";
            this.output_lb.Size = new System.Drawing.Size(381, 205);
            this.output_lb.TabIndex = 0;
            // 
            // tinh_bt
            // 
            this.tinh_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tinh_bt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinh_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tinh_bt.Location = new System.Drawing.Point(401, 385);
            this.tinh_bt.Name = "tinh_bt";
            this.tinh_bt.Size = new System.Drawing.Size(134, 57);
            this.tinh_bt.TabIndex = 1;
            this.tinh_bt.Text = "Tính";
            this.tinh_bt.UseVisualStyleBackColor = false;
            this.tinh_bt.Click += new System.EventHandler(this.tinh_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tính toán trên file";
            // 
            // b3_l2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB2.Properties.Resources.lab3_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tinh_bt);
            this.Controls.Add(this.output_lb);
            this.Controls.Add(this.input_tb);
            this.DoubleBuffered = true;
            this.Name = "b3_l2";
            this.Text = "b3_l2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_tb;
        private System.Windows.Forms.TextBox output_lb;
        private System.Windows.Forms.Button tinh_bt;
        private System.Windows.Forms.Label label3;
    }
}