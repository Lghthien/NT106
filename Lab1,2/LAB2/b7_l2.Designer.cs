namespace LAB2
{
    partial class b7_l2
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
            this.danhsach_tv = new System.Windows.Forms.TreeView();
            this.output_tc = new System.Windows.Forms.TabControl();
            this.Picture_TC = new System.Windows.Forms.TabPage();
            this.Text_TC = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.output_tc.SuspendLayout();
            this.Picture_TC.SuspendLayout();
            this.Text_TC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // danhsach_tv
            // 
            this.danhsach_tv.Location = new System.Drawing.Point(0, 0);
            this.danhsach_tv.Name = "danhsach_tv";
            this.danhsach_tv.Size = new System.Drawing.Size(219, 450);
            this.danhsach_tv.TabIndex = 0;
            this.danhsach_tv.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.danhsach_tv_BeforeExpand);
            this.danhsach_tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.danhsach_tv_NodeMouseDoubleClick_1);
            // 
            // output_tc
            // 
            this.output_tc.Controls.Add(this.Picture_TC);
            this.output_tc.Controls.Add(this.Text_TC);
            this.output_tc.Location = new System.Drawing.Point(216, 0);
            this.output_tc.Name = "output_tc";
            this.output_tc.SelectedIndex = 0;
            this.output_tc.Size = new System.Drawing.Size(583, 450);
            this.output_tc.TabIndex = 1;
            // 
            // Picture_TC
            // 
            this.Picture_TC.Controls.Add(this.pictureBox1);
            this.Picture_TC.Location = new System.Drawing.Point(4, 25);
            this.Picture_TC.Name = "Picture_TC";
            this.Picture_TC.Padding = new System.Windows.Forms.Padding(3);
            this.Picture_TC.Size = new System.Drawing.Size(575, 421);
            this.Picture_TC.TabIndex = 0;
            this.Picture_TC.Text = "Picture";
            this.Picture_TC.UseVisualStyleBackColor = true;
            // 
            // Text_TC
            // 
            this.Text_TC.Controls.Add(this.textBox1);
            this.Text_TC.Location = new System.Drawing.Point(4, 25);
            this.Text_TC.Name = "Text_TC";
            this.Text_TC.Padding = new System.Windows.Forms.Padding(3);
            this.Text_TC.Size = new System.Drawing.Size(575, 421);
            this.Text_TC.TabIndex = 1;
            this.Text_TC.Text = "Text";
            this.Text_TC.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 415);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b7_l2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output_tc);
            this.Controls.Add(this.danhsach_tv);
            this.Name = "b7_l2";
            this.Text = "Cây thư mục";
            this.output_tc.ResumeLayout(false);
            this.Picture_TC.ResumeLayout(false);
            this.Text_TC.ResumeLayout(false);
            this.Text_TC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView danhsach_tv;
        private System.Windows.Forms.TabControl output_tc;
        private System.Windows.Forms.TabPage Picture_TC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Text_TC;
        private System.Windows.Forms.TextBox textBox1;
    }
}