using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机时间
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            #region 随机时间,时间格式 6:00


            for (int i = 0; i < 10; i++)
            {
                int hour = DateTime.Now.Hour-10 + r.Next(0, 10);
                int minute = DateTime.Now.Minute + r.Next(0, 10);
                Console.WriteLine(hour + ":" + minute);
            }
            #endregion

            #region 随机日期，日期格式 2020 - 4 - 23

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            for (int i = 0; i < 20; i++)
            {
                year = DateTime.Now.Year - r.Next(0, 5);
                month = DateTime.Now.Month - r.Next(0,13);
                day = DateTime.Now.Day - r.Next(0, 32);

                Console.WriteLine("{0}-{1}-{2}",year,month,day);
            }

            #endregion

            #region  提取身份证出生日期  410901198304055544 提取格式：1983-4-5 

            //需要提取的身份证号
            string[] ID =
                { "410901196812194541", "410928196802180648", "410926199010181643",
                "410901198307245511","410901198304055544"
            };

            string tmp = "";

            for (int i = 0; i < ID.Length; i++)
            {
                //截取 7 - 10 位数字,获取出生日期
                tmp = ID[i].Substring(6, 8); //拿到19830405 

                //19680218
                //对出生日期进行字符串处理,第0-3个索引加一个 -，第4个加，第6个加
                //1983 + "-" + 04 + "-" + 05
                ID[i] = tmp.Substring(0,4)+"-"+tmp.Substring(4,2)+"-"+tmp.Substring(6,2);

            }
            for (int i = 0; i < ID.Length; i++)
            {
                Console.WriteLine(ID[i]);
            }
            #endregion
        }
    }
}
