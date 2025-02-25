namespace LAB2
{
    partial class b2_l2
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
            this.read_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.output_tb = new System.Windows.Forms.TextBox();
            this.filename_tb = new System.Windows.Forms.TextBox();
            this.size_tb = new System.Windows.Forms.TextBox();
            this.URL_tb = new System.Windows.Forms.TextBox();
            this.lineCount_tb = new System.Windows.Forms.TextBox();
            this.words_tb = new System.Windows.Forms.TextBox();
            this.Character_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // read_bt
            // 
            this.read_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read_bt.Location = new System.Drawing.Point(116, 91);
            this.read_bt.Name = "read_bt";
            this.read_bt.Size = new System.Drawing.Size(222, 36);
            this.read_bt.TabIndex = 0;
            this.read_bt.Text = "Read from file";
            this.read_bt.UseVisualStyleBackColor = true;
            this.read_bt.Click += new System.EventHandler(this.read_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.Color.Red;
            this.exit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_bt.ForeColor = System.Drawing.Color.Yellow;
            this.exit_bt.Location = new System.Drawing.Point(184, 438);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(102, 35);
            this.exit_bt.TabIndex = 1;
            this.exit_bt.Text = "Exit";
            this.exit_bt.UseVisualStyleBackColor = false;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(103, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Words count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(103, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Character count";
            // 
            // output_tb
            // 
            this.output_tb.Enabled = false;
            this.output_tb.Location = new System.Drawing.Point(386, 91);
            this.output_tb.Multiline = true;
            this.output_tb.Name = "output_tb";
            this.output_tb.Size = new System.Drawing.Size(536, 382);
            this.output_tb.TabIndex = 3;
            // 
            // filename_tb
            // 
            this.filename_tb.Enabled = false;
            this.filename_tb.Location = new System.Drawing.Point(226, 133);
            this.filename_tb.Name = "filename_tb";
            this.filename_tb.Size = new System.Drawing.Size(130, 22);
            this.filename_tb.TabIndex = 4;
            // 
            // size_tb
            // 
            this.size_tb.Enabled = false;
            this.size_tb.Location = new System.Drawing.Point(226, 189);
            this.size_tb.Name = "size_tb";
            this.size_tb.Size = new System.Drawing.Size(130, 22);
            this.size_tb.TabIndex = 5;
            // 
            // URL_tb
            // 
            this.URL_tb.Enabled = false;
            this.URL_tb.Location = new System.Drawing.Point(226, 240);
            this.URL_tb.Name = "URL_tb";
            this.URL_tb.Size = new System.Drawing.Size(130, 22);
            this.URL_tb.TabIndex = 5;
            // 
            // lineCount_tb
            // 
            this.lineCount_tb.Enabled = false;
            this.lineCount_tb.Location = new System.Drawing.Point(226, 293);
            this.lineCount_tb.Name = "lineCount_tb";
            this.lineCount_tb.Size = new System.Drawing.Size(130, 22);
            this.lineCount_tb.TabIndex = 5;
            // 
            // words_tb
            // 
            this.words_tb.Enabled = false;
            this.words_tb.Location = new System.Drawing.Point(226, 346);
            this.words_tb.Name = "words_tb";
            this.words_tb.Size = new System.Drawing.Size(130, 22);
            this.words_tb.TabIndex = 5;
            // 
            // Character_tb
            // 
            this.Character_tb.Enabled = false;
            this.Character_tb.Location = new System.Drawing.Point(226, 404);
            this.Character_tb.Name = "Character_tb";
            this.Character_tb.Size = new System.Drawing.Size(130, 22);
            this.Character_tb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(489, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tìm các thông số của file";
            // 
            // b2_l2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB2.Properties.Resources.lab2_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 521);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Character_tb);
            this.Controls.Add(this.words_tb);
            this.Controls.Add(this.lineCount_tb);
            this.Controls.Add(this.URL_tb);
            this.Controls.Add(this.size_tb);
            this.Controls.Add(this.filename_tb);
            this.Controls.Add(this.output_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.read_bt);
            this.DoubleBuffered = true;
            this.Name = "b2_l2";
            this.Text = "b2_l2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_bt;
        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox output_tb;
        private System.Windows.Forms.TextBox filename_tb;
        private System.Windows.Forms.TextBox size_tb;
        private System.Windows.Forms.TextBox URL_tb;
        private System.Windows.Forms.TextBox lineCount_tb;
        private System.Windows.Forms.TextBox words_tb;
        private System.Windows.Forms.TextBox Character_tb;
        private System.Windows.Forms.Label label7;
    }
}