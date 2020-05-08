using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 整合数据
            //Random r = new Random();
            ////存储姓名
            //string[] name = new string[100];
            ////存储工资
            //string[] salary = new string[100];

            ////整合信息
            //string[] all = new string[100];

            ////读取人名存进数组
            //name= File.ReadAllLines(@"C:\Users\一世长安\Desktop\人名.txt");
            ////读取工资存进数组
            //salary = File.ReadAllLines(@"C:\Users\一世长安\Desktop\工资.txt");

            //for (int i = 0; i < all.Length; i++)
            //{
            //    all[i] = name[i] + "|" + salary[i];
            //}

            ////合并成新的txt文件 格式： 姓名|工资   一行一个
            //File.WriteAllLines(@"C:\Users\一世长安\Desktop\数据.txt",all);

            #endregion

            //读取文档里的人名|工资，每个人的工资翻倍，然后放到一个新文件里面

            //读取文档 str[0] = "张三|10000"
            string[] str = File.ReadAllLines(@"C: \Users\一世长安\Desktop\工资.txt", Encoding.UTF8);

            for (int i = 0; i < str.Length; i++)
            {
                //拿到工资部分,使用split分割，返回一个字符串数组:[0]张三 [1]10000
                string[] tmp = str[i].Split(new char[] { '|' });
                //把工资部分转换成int类型并翻倍
                int salary = Convert.ToInt32(tmp[1]) * 2;
                //把翻倍后的工资放回去
                tmp[1] = salary.ToString();
                //最后把工资还原到初始数组内,此时工资已经翻倍
                str[i] = tmp[0] + "|" + tmp[1];
            }
            //写入新文件
            File.WriteAllLines(@"C: \Users\一世长安\Desktop\工资翻倍后.txt", str);

        }


    }
}
