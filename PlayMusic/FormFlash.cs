using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic
{
    /// <summary>
    /// 窗体动画效果类
    /// </summary>
    class FormFlash
    {
       /// <summary>
       /// 渐入动画
       /// </summary>
       /// <param name="sender">需要渐入的窗体</param>
       /// <param name="flashtimer">所需的时钟控件类</param>
        public static void EnterForm(object sender,Timer flashtimer)
        {
            Form fm = (Form)sender;
            if (fm.Opacity < 1)
            {
                fm.Opacity += 0.08;
            }
            else
            {
                flashtimer.Enabled = false;
            }
        }



        /// <summary>
        /// 渐出效果
        /// </summary>
        /// <param name="sender">需要渐出的窗体</param>
        /// <param name="flashtimer">所需的时钟控件类</param>
        public static void ExtiForm(object sender, Timer flashtimer)
        {
            Form fm = (Form)sender;
            if (fm.Opacity > 0)
            {
                fm.Opacity -= 0.08;
            }
            else
            {
                fm.Close();
                flashtimer.Enabled = false;
            }
        }
    }
}
