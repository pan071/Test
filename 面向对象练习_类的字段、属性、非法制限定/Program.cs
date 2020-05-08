using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习_类的字段_属性_非法制限定
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用new关键字创建类的对象(类的实例化)
            //括号里面写的是调用构造函数传入的值
            Person p = new Person("张三",-18,'中',-60);

            //调用这个类的方法
            p.SayHello();


        }
    }
}
