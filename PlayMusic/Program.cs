using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 作者:Wumeng
/// 结束时间:2015-3-18
/// 邮箱:1170621609@qq.com
/// </summary>
namespace PlayMusic
{
    static class Program
    {
       
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //判断程序进程是否存在
            if (Process.GetProcessesByName("PlayMusic").Length > 1)
            {
                return;
            }
            Application.Run(new frmPlayMusic());
        }
    }
}
