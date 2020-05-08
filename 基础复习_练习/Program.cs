using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础复习_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入进入的磁盘:");
            string path = Console.ReadLine();

            Console.WriteLine("请输入要打开的文件(*.*)");
            string fillName = Console.ReadLine();

            FileFather ff = GetFileName(fillName,path+fillName);
            ff.OpenFile();

        }

        public static FileFather GetFileName(string fileName, string fullPath)
        {
            //拿到文件拓展名
            string extension = Path.GetExtension(fileName);
            FileFather ff = null;

            //根据文件拓展名new子类对象
            switch (extension)
            {
                case ".txt":
                    ff = new TxtFile(fullPath);
                    break;
            }
            return ff;
        }

        //abstract：抽象类
        public abstract class FileFather
        {
            //使用字段存储全路径
            public string fullPath
            {
                get;
                set;
            }

            //构造函数，传入文件全路径
            public FileFather(string fullpath)
            {
                this.fullPath = fullpath;
            }

            //打开文件的方法
            public abstract void OpenFile();
        }

        /// <summary>
        /// txt文件
        /// </summary>
        public class TxtFile : FileFather
        {
            //打开文件方法
            public override void OpenFile()
            {
                //ProcessStartInfo必须拿到全路径
                ProcessStartInfo psi = new ProcessStartInfo(this.fullPath);
                Process p = new Process();
                p.StartInfo = psi;
                p.Start();
            }

            //构造函数
            public TxtFile(string fullpath) : base(fullpath)
            {

            }
        }



    }
}
