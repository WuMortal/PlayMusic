using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic
{
    public partial class frmPlayMusic : Form
    {
        int MousX, MousY;
        public frmPlayMusic()
        {
            InitializeComponent();

            //美化listbox选项
            listMusicMenu.DrawMode = DrawMode.OwnerDrawFixed;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Height = 82;

            lblExit.Image = Properties.Resources.closeFrom;
            //窗体透明
            this.BackColor = Color.FromArgb(151, 190, 144);
            this.TransparencyKey = Color.FromArgb(151, 190, 144);

            //取消自动播放
            musicPlays.settings.autoStart = false;

            //判断保存播放列表文件是否存在  存在并添加到列表中
            if (File.Exists(Application.StartupPath + "\\PlaysList.pls"))
            {
                SaveMusicListFile.GetMusicList(ref listPath);
                for (int i = 0; i < listPath.Count; i++)
                {
                    AddMusicListMenu(i);
                }
                SetMusicNumber();
                addMusicNumber++;
            }

        }
        

        /// <summary>
        /// 窗体移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MousX = e.X;
                MousY = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - MousX), this.Location.Y + (e.Y - MousY));
            }
        }


        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPrev_MouseEnter(object sender, EventArgs e)
        {
            changeImg(picPrev,Properties.Resources.aft_prev);
        }

        private void picPrev_MouseLeave(object sender, EventArgs e)
        {
            changeImg(picPrev, Properties.Resources.prev);
        }

        /// <summary>
        /// 上一曲按下动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPrev_MouseDown(object sender, MouseEventArgs e)
        {
            changeImgeSize(picPrev, 1);
        }

        private void picPrev_MouseUp(object sender, MouseEventArgs e)
        {
            changeImgeSize(picPrev, 2);
        }




        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picNext_MouseEnter(object sender, EventArgs e)
        {
            changeImg(picNext, Properties.Resources.aft_next);
        }

        private void picNext_MouseLeave(object sender, EventArgs e)
        {
            changeImg(picNext, Properties.Resources.next);
        }

        /// <summary>
        /// 下一曲按下动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picNext_MouseDown(object sender, MouseEventArgs e)
        {
            changeImgeSize(picNext, 1);
        }

        private void picNext_MouseUp(object sender, MouseEventArgs e)
        {
            changeImgeSize(picNext, 2);
        }



        /// <summary>
        /// 播放暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPlay_Click(object sender, EventArgs e)
        {
           
            //列表中有数据才能播放
            if (listMusicMenu.Items.Count == 0)
            {
                MessageBox.Show("请添加音乐文件.", "操作提示");
                this.Height = 383;
                groupMenu.Visible = true;
                picMenu.Tag = 2;
                return;
            }
            else
            {
                //当播放列表中有数据且没有选中项时默认播放第一首 
                if (listMusicMenu.SelectedIndex==-1)
                {
                    musicPlays.URL = listPath[0];
                    listMusicMenu.SelectedIndices.Clear();
                    listMusicMenu.SelectedIndex = 0;
                    ChangeMusicName();
                }
            }

           

            if (picPlay.Tag.ToString() == "1")
            {
                changeImg(picPlay, Properties.Resources.pause);

                //播放音乐
                musicPlays.Ctlcontrols.play();
               
                picPlay.Tag = 2;
            }
            else
            {
                changeImg(picPlay, Properties.Resources.play);

                //暂停音乐
                musicPlays.Ctlcontrols.pause();

                picPlay.Tag = 1;
            }
        }

        /// <summary>
        /// 改变显示歌曲名称
        /// </summary>
        private void ChangeMusicName()
        {
            lblMusicName.Text = Path.GetFileNameWithoutExtension(listPath[listMusicMenu.SelectedIndex]);
        }


        /// <summary>
        /// 按下动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPlay_MouseDown(object sender, MouseEventArgs e)
        {
            changeImgeSize(picPlay,1);
        }

        private void picPlay_MouseUp(object sender, MouseEventArgs e)
        {
            changeImgeSize(picPlay, 2);
        }



        /// <summary>
        /// 更换控件背景图片
        /// </summary>
        /// <param name="pic">图片类</param>
        /// <param name="imgPath1">图片</param>
        private void changeImg(PictureBox pic,Bitmap imgPath1)
        {
                pic.Image = imgPath1;
        }


        /// <summary>
        ///歌单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMenu_MouseEnter(object sender, EventArgs e)
        {
            changeImg(picMenu, Properties.Resources.aft_menu);
        }

        private void picMenu_MouseLeave(object sender, EventArgs e)
        {
            changeImg(picMenu, Properties.Resources.menu);
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            if (picMenu.Tag.ToString() == "1")
            {
                this.Height = 390;
                groupMenu.Visible = true;
                picMenu.Tag = 2;    
            }
            else if(picMenu.Tag.ToString() == "2")
            {
                this.Height = 82;
                groupMenu.Visible = false;
                picMenu.Tag = 1;
            }
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            this.timer3.Enabled = true;
        }

        /// <summary>
        /// 单击窗体收起菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Click(object sender, EventArgs e)
        {
            groupMenu.Visible = false;
            picMenu.Tag = 1;
        }


        //存储音乐文件全路径
        List<string> listPath = new List<string>();
        int addMusicNumber = 0;
        string[] musicName;
        /// <summary>
        /// 添加音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAppMusic_Click(object sender, EventArgs e)
        {
            int musicNumber = 0; //添加歌曲数量
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "MP3文件|*.mp3|音乐文件|*.wav|所有文件|*.*";
            ofd.Title = "请选择音乐文件";
            ofd.Multiselect = true;

            //判断是否选择文件
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                string[] musicFilePath = ofd.FileNames;
                for (int i = 0; i < musicFilePath.Length; i++)
                {
                    //存储音乐全路径 泛型集合
                    if (listPath.Contains(musicFilePath[i]))
                    {
                        continue;
                    }
                    else
                    {
                        listPath.Add(musicFilePath[i]);
                        AddMusicListMenu(i);

                        musicNumber++; 
                    }
                }

                MessageBox.Show("成功添加歌曲"+musicNumber+"首","操作提示");
                SetMusicNumber();

                SaveMusicListFile.SaveMusicList(listPath);

                addMusicNumber++;

            }
           
        }

        /// <summary>
        /// 将音乐信息添加在列表框中
        /// </summary>
        /// <param name="i"></param>
        private void AddMusicListMenu(int i)
        {

            //判断是否为第一次添加音乐
            if (addMusicNumber == 0)
            {
                //分割歌曲名个歌手
                musicName = Path.GetFileNameWithoutExtension(listPath[i]).Split('-');
                if (musicName[1].Length >= 10)
                {
                    musicName[1] = musicName[1].Substring(0, 10) + "...";
                }

                //限制最大长度
                byte[] data = Encoding.Default.GetBytes(musicName[1]);

                byte[] data2 = new byte[41];
                for (int j = 0; j < 41; j++)
                {
                    if (data.GetLength(0) > j)
                    {
                        data2[j] = data[j];
                    }
                    else
                    {
                        data2[j] = 0;
                    }

                }

                string newMusicName = Encoding.Default.GetString(data2);
                musicName[1] = newMusicName;
                listMusicMenu.Items.Add(musicName[1] + " " + musicName[0]);
            }
            else
            {
                string[] musicName = Path.GetFileNameWithoutExtension(listPath[listPath.Count - 1]).Split('-');
                if (musicName[1].Length >= 10)
                {
                    musicName[1] = musicName[1].Substring(0, 10) + "...";
                }
                //限制最大长度
                byte[] data = Encoding.Default.GetBytes(musicName[1]);

                byte[] data2 = new byte[31];
                for (int j = 0; j < 31; j++)
                {
                    if (data.GetLength(0) > j)
                    {
                        data2[j] = data[j];
                    }
                    else
                    {
                        data2[j] = 0;
                    }

                }

                string newMusicName = Encoding.Default.GetString(data2);
                musicName[1] = newMusicName;
                listMusicMenu.Items.Add(musicName[1] + " " + musicName[0]);
            }
        }



        /// <summary>
        /// 双击播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listMusicMenu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                musicPlays.URL = listPath[listMusicMenu.SelectedIndex];

                RemoveVoidMuisc(sender, e);

                musicPlays.Ctlcontrols.play();
                changeImg(picPlay, Properties.Resources.pause);
                picPlay.Tag = 2;
                ChangeMusicName();
            }
            catch {}
        }


        /// <summary>
        /// 移除不存在或硬盘中已删除的音乐，并且自动播放下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveVoidMuisc(object sender, EventArgs e)
        {
            if (!File.Exists(listPath[listMusicMenu.SelectedIndex]))
            {
                删除ToolStripMenuItem_Click(sender, e);
                picNext_Click(sender, e);
                MessageBox.Show("播放的音乐文件不存在。", "操作提示");
            }
        }


        /// <summary>
        /// 赋值列表中歌曲数量
        /// </summary>
        /// <returns></returns>
        private  void  SetMusicNumber()
        {
            groupMenu.Text =groupMenu.Text.Substring(0,11)+listMusicMenu.Items.Count;
        }

        private Color RowBackColorAlt = Color.FromArgb(249, 249, 249);//交替色   
        private Color RowBackColorSel = Color.FromArgb(222, 222, 224);//选择项目颜色

        /// <summary>
        /// 重绘ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listMusicMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Brush myBrush = Brushes.Black;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    myBrush = new SolidBrush(RowBackColorSel);
                }
                else if (e.Index % 2 == 0)
                {
                    myBrush = new SolidBrush(RowBackColorAlt);
                }
                else
                {
                    myBrush = new SolidBrush(Color.White);
                }
                e.Graphics.FillRectangle(myBrush, e.Bounds);
                e.DrawFocusRectangle();//焦点框   
                listMusicMenu.ItemHeight = 40;
                //绘制字体   
                Graphics g = e.Graphics;
                Rectangle bounds = e.Bounds;
                Rectangle textRect = new Rectangle(0, bounds.Y, bounds.Width, bounds.Height);

                //文本   
                StringFormat strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;   //列表框项文字横向  从左至右
                strFormat.LineAlignment = StringAlignment.Center;  //垂直居中

                e.Graphics.DrawString(listMusicMenu.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), textRect, strFormat);
            }
            catch{}
        }

        private void picPrev_Click(object sender, EventArgs e)
        {
            if (listMusicMenu.Items.Count != 0)
            {
                changeImg(picPlay, Properties.Resources.pause);
                picPlay.Tag = 2;
            }

            try
            {
                int index = listMusicMenu.SelectedIndex;

                //清除选中项
                listMusicMenu.SelectedIndices.Clear();
                index--;
                if (index<0)
                {
                    index = listMusicMenu.Items.Count-1;
                }

                listMusicMenu.SelectedIndex = index;
                musicPlays.URL = listPath[index];

                RemoveVoidMuisc(sender, e);

                musicPlays.Ctlcontrols.play();
                ChangeMusicName();
            }
            catch { }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            if (listMusicMenu.Items.Count != 0)
            {
                changeImg(picPlay, Properties.Resources.pause);
                picPlay.Tag = 2;
            }

            try
            {
                int index = listMusicMenu.SelectedIndex;

                //清除选中项
                listMusicMenu.SelectedIndices.Clear();

                index++;
                if (index == listMusicMenu.Items.Count)
                {
                    index = 0;
                }

                listMusicMenu.SelectedIndex = index;
                musicPlays.URL = listPath[index];

                RemoveVoidMuisc(sender, e);

                musicPlays.Ctlcontrols.play();
                ChangeMusicName();
            }
            catch{ }
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除列表中的选中项
            //获取需要删除歌曲的数量
            int count = listMusicMenu.SelectedItems.Count;

            for (int i = 0; i < count; i++)
            {
                listPath.RemoveAt(listMusicMenu.SelectedIndex);

                listMusicMenu.Items.RemoveAt(listMusicMenu.SelectedIndex);
            }
            SaveMusicListFile.SaveMusicList(listPath);
        }


       /// <summary>
       /// 播放时间显示
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果播放器的状态等于正在播放中

            if (musicPlays.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //musicPlays.currentMedia.duration.ToString()       musicPlays.currentMedia.durationString   播放总时间   第一个为毫秒  第二个位 00:00显示
                lblMusicTime.Text = musicPlays.Ctlcontrols.currentPositionString + "/" + musicPlays.currentMedia.durationString;

                //musicPlays.Ctlcontrols.currentPosition.ToString()  musicPlays.Ctlcontrols.currentPositionString   播放了的时间   第一个为毫秒  第二个位 00:00显示
            }
        }
        
        /// <summary>
        /// 自动播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicPlays_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
            if (musicPlays.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //获得当前选中项的索引
                int index = listMusicMenu.SelectedIndex;

                //清空所有选中项的索引
                listMusicMenu.SelectedIndices.Clear();
                index++;
                if (index == listMusicMenu.Items.Count)
                {
                    index = 0;
                }
                //将改变后的索引重新的赋值给当前选中项的索引
                listMusicMenu.SelectedIndex = index;
                musicPlays.URL = listPath[index];

            }
            if (musicPlays.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                try
                {
                    musicPlays.Ctlcontrols.play();
                }
                catch { }
            }
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            frmAboutMessageBox fmb = new frmAboutMessageBox();
            fmb.ShowDialog();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            FormFlash.EnterForm(this,timer2);

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            FormFlash.ExtiForm(this, timer3);
        }

        /// <summary>
        /// 控件按下动画
        /// </summary>
        /// <param name="pic">图片对象</param>
        /// <param name="tap">是按下，还是松开</param>
        private void changeImgeSize(PictureBox pic,int tap)
        {
            if (tap==1)
            {
                pic.Size = new Size(38,34);
            }
            else if (tap==2)
            {
                pic.Size = new Size(40, 36);
            }
            
        }
    }
}
