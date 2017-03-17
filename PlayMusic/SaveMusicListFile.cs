using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusic
{
    class SaveMusicListFile
    {
        /// <summary>
        /// 保存列表歌曲
        /// </summary>
        /// <param name="objStudent"></param>
        public static void SaveMusicList(List<string> listPath)
        {
           
            //保存对象到文本文件
            FileStream fs = new FileStream("PlaysList.pls", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < listPath.Count; i++)
            {
                sw.WriteLine(listPath[i]);
            }
            sw.Close();
            fs.Close();
        }


        /// <summary>
        /// 读取音乐列表信息
        /// </summary>
        public static void GetMusicList(ref List<string> listPath)
        {
            //读取文件
            FileStream fs = new FileStream("PlaysList.pls", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            for (int i = 0;sr.Peek() >= 0; i++)
            {

                //判断是否超出原有数据
                if (i < listPath.Count)
                {
                    listPath[i] = sr.ReadLine();
                }
                else
                {
                    listPath.Add(sr.ReadLine());
                }
                
            }
            fs.Close();
            fs.Close();
        }
        
    }
}
