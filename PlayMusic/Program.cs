using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("程序已运行!", "提示");
                return;
            }
            Application.Run(new frmPlayMusic());
        }
    }
}
