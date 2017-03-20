namespace PlayMusic
{
    partial class frmPlayMusic
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayMusic));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblMusicTime = new System.Windows.Forms.Label();
            this.lblMusicName = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblAppMusic = new System.Windows.Forms.Label();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.pricBLogo = new System.Windows.Forms.PictureBox();
            this.musicPlays = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.listMusicMenu = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlays)).BeginInit();
            this.groupMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(1, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblAbout);
            this.panel1.Controls.Add(this.lblMusicTime);
            this.panel1.Controls.Add(this.lblMusicName);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblAppMusic);
            this.panel1.Controls.Add(this.picMenu);
            this.panel1.Controls.Add(this.picNext);
            this.panel1.Controls.Add(this.picPlay);
            this.panel1.Controls.Add(this.picPrev);
            this.panel1.Controls.Add(this.pricBLogo);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 80);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAbout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAbout.ForeColor = System.Drawing.Color.DimGray;
            this.lblAbout.Location = new System.Drawing.Point(390, 2);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(32, 17);
            this.lblAbout.TabIndex = 8;
            this.lblAbout.Text = "关于";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // lblMusicTime
            // 
            this.lblMusicTime.AutoSize = true;
            this.lblMusicTime.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMusicTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblMusicTime.Location = new System.Drawing.Point(304, 13);
            this.lblMusicTime.Name = "lblMusicTime";
            this.lblMusicTime.Size = new System.Drawing.Size(32, 17);
            this.lblMusicTime.TabIndex = 7;
            this.lblMusicTime.Text = "0:00";
            // 
            // lblMusicName
            // 
            this.lblMusicName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMusicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblMusicName.Location = new System.Drawing.Point(92, 7);
            this.lblMusicName.Name = "lblMusicName";
            this.lblMusicName.Size = new System.Drawing.Size(210, 20);
            this.lblMusicName.TabIndex = 6;
            this.lblMusicName.Text = "发现好音乐,享受生活...";
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblExit.Location = new System.Drawing.Point(432, 1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 19);
            this.lblExit.TabIndex = 5;
            this.lblExit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAppMusic
            // 
            this.lblAppMusic.BackColor = System.Drawing.Color.Transparent;
            this.lblAppMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppMusic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAppMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblAppMusic.Location = new System.Drawing.Point(375, 54);
            this.lblAppMusic.Name = "lblAppMusic";
            this.lblAppMusic.Size = new System.Drawing.Size(68, 17);
            this.lblAppMusic.TabIndex = 4;
            this.lblAppMusic.Text = "+添加音乐";
            this.lblAppMusic.Click += new System.EventHandler(this.lblAppMusic_Click);
            // 
            // picMenu
            // 
            this.picMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(385, 33);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(21, 16);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 4;
            this.picMenu.TabStop = false;
            this.picMenu.Tag = "1";
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            this.picMenu.MouseEnter += new System.EventHandler(this.picMenu_MouseEnter);
            this.picMenu.MouseLeave += new System.EventHandler(this.picMenu_MouseLeave);
            // 
            // picNext
            // 
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Image = global::PlayMusic.Properties.Resources.next;
            this.picNext.Location = new System.Drawing.Point(266, 35);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(40, 36);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNext.TabIndex = 3;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            this.picNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNext_MouseDown);
            this.picNext.MouseEnter += new System.EventHandler(this.picNext_MouseEnter);
            this.picNext.MouseLeave += new System.EventHandler(this.picNext_MouseLeave);
            this.picNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNext_MouseUp);
            // 
            // picPlay
            // 
            this.picPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlay.Image = global::PlayMusic.Properties.Resources.play;
            this.picPlay.Location = new System.Drawing.Point(181, 35);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(40, 36);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlay.TabIndex = 2;
            this.picPlay.TabStop = false;
            this.picPlay.Tag = "1";
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            this.picPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseDown);
            this.picPlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPlay_MouseUp);
            // 
            // picPrev
            // 
            this.picPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPrev.Image = global::PlayMusic.Properties.Resources.prev;
            this.picPrev.Location = new System.Drawing.Point(96, 35);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(40, 36);
            this.picPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrev.TabIndex = 1;
            this.picPrev.TabStop = false;
            this.picPrev.Click += new System.EventHandler(this.picPrev_Click);
            this.picPrev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picPrev_MouseDown);
            this.picPrev.MouseEnter += new System.EventHandler(this.picPrev_MouseEnter);
            this.picPrev.MouseLeave += new System.EventHandler(this.picPrev_MouseLeave);
            this.picPrev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picPrev_MouseUp);
            // 
            // pricBLogo
            // 
            this.pricBLogo.Image = global::PlayMusic.Properties.Resources.logo;
            this.pricBLogo.Location = new System.Drawing.Point(1, 1);
            this.pricBLogo.Name = "pricBLogo";
            this.pricBLogo.Size = new System.Drawing.Size(76, 74);
            this.pricBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pricBLogo.TabIndex = 0;
            this.pricBLogo.TabStop = false;
            // 
            // musicPlays
            // 
            this.musicPlays.Enabled = true;
            this.musicPlays.Location = new System.Drawing.Point(1, 397);
            this.musicPlays.Name = "musicPlays";
            this.musicPlays.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlays.OcxState")));
            this.musicPlays.Size = new System.Drawing.Size(43, 33);
            this.musicPlays.TabIndex = 1;
            this.musicPlays.Visible = false;
            this.musicPlays.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPlays_PlayStateChange);
            // 
            // groupMenu
            // 
            this.groupMenu.BackColor = System.Drawing.Color.White;
            this.groupMenu.Controls.Add(this.listMusicMenu);
            this.groupMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.groupMenu.Location = new System.Drawing.Point(1, 82);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(460, 309);
            this.groupMenu.TabIndex = 5;
            this.groupMenu.TabStop = false;
            this.groupMenu.Tag = "1";
            this.groupMenu.Text = "播放列表——歌曲数量:";
            this.groupMenu.Visible = false;
            // 
            // listMusicMenu
            // 
            this.listMusicMenu.BackColor = System.Drawing.Color.White;
            this.listMusicMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMusicMenu.ContextMenuStrip = this.contextMenuStrip1;
            this.listMusicMenu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listMusicMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.listMusicMenu.FormattingEnabled = true;
            this.listMusicMenu.ItemHeight = 20;
            this.listMusicMenu.Location = new System.Drawing.Point(6, 23);
            this.listMusicMenu.Name = "listMusicMenu";
            this.listMusicMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listMusicMenu.Size = new System.Drawing.Size(451, 280);
            this.listMusicMenu.TabIndex = 6;
            this.listMusicMenu.Tag = "";
            this.listMusicMenu.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listMusicMenu_DrawItem);
            this.listMusicMenu.DoubleClick += new System.EventHandler(this.listMusicMenu_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.删除ToolStripMenuItem.Text = "删 除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmPlayMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 393);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.musicPlays);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlayMusic";
            this.Opacity = 0.1D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniPlayMusic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlays)).EndInit();
            this.groupMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer musicPlays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pricBLogo;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Label lblAppMusic;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.ListBox listMusicMenu;
        private System.Windows.Forms.Label lblMusicName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMusicTime;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

