namespace PlayMusic
{
    partial class frmAboutMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutMessageBox));
            this.lblOK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAboutText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOK
            // 
            this.lblOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.lblOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOK.ForeColor = System.Drawing.Color.White;
            this.lblOK.Location = new System.Drawing.Point(200, 15);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(74, 25);
            this.lblOK.TabIndex = 1;
            this.lblOK.Text = "确定";
            this.lblOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOK.Click += new System.EventHandler(this.lblOK_Click);
            this.lblOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOK_MouseDown);
            this.lblOK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblOK_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOK);
            this.groupBox1.Location = new System.Drawing.Point(-1, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtAboutText
            // 
            this.txtAboutText.BackColor = System.Drawing.Color.White;
            this.txtAboutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboutText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAboutText.ForeColor = System.Drawing.Color.Black;
            this.txtAboutText.Location = new System.Drawing.Point(6, 42);
            this.txtAboutText.Multiline = true;
            this.txtAboutText.Name = "txtAboutText";
            this.txtAboutText.ReadOnly = true;
            this.txtAboutText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAboutText.Size = new System.Drawing.Size(273, 125);
            this.txtAboutText.TabIndex = 3;
            this.txtAboutText.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmAboutMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 216);
            this.Controls.Add(this.txtAboutText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAboutMessageBox";
            this.Opacity = 0.1D;
            this.Text = "frmMessageBox";
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAboutText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}