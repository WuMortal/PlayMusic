using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PlayMusic
{
    public partial class frmAboutMessageBox : Form
    {
        public frmAboutMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体阴影   代码来源:http://www.jb51.net/article/41921.htm
        /// </summary>
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        /// <summary>
        /// 窗体阴影
        /// </summary>
        private void SetShadow()
        {
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }



        /// <summary>
        /// 关于软件信息存储
        /// </summary>
        public string AboutSoftware { get; set; }


        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            frmPlayMusic fpm = new frmPlayMusic();
            this.Location = new Point(fpm.Left+100,fpm.Top-60);
            SetShadow();
            AboutSoftware = "MLMP:1.0\r\nWumeng 版权所有@2017\r\n更新日期:2017-3-18\r\nMiniMusicLocalPlay是一款小巧玲珑的本地播放器。\r\n邮箱地址:wumengnokia@outlook.com\r\n免责声明: 本产品中提供的软件之著作权归软件作者所有。用户可以自由选择是否使用本产品提供的软件。如果用户下载、安装、使用本产品中所提供的软件，即表明用户信任该软件作者，对任何原因在使用本产品中提供的软件时可能对用户自己或他人造成的任何形式的损失和伤害不承担责任。";
            txtAboutText.Text = AboutSoftware;
        }

        private void lblOK_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void lblOK_MouseDown(object sender, MouseEventArgs e)
        {
            lblOK.Location = new Point(lblOK.Left + 2, lblOK.Top + 2);
        }

        private void lblOK_MouseUp(object sender, MouseEventArgs e)
        {
            lblOK.Location = new Point(lblOK.Left - 2, lblOK.Top - 2);
        }


        /// <summary>
        /// 渐入动画
        /// </summary>
        /// <param name="sender"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            FormFlash.EnterForm(this, timer1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            FormFlash.ExtiForm(this, timer2);
        }
    }
}
