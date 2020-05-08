using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //简单工厂设计模式 + 继承 实现一个计算器
                Console.WriteLine("请输入第一个数字:");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个数字:");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入运算符:");
                string opera = Console.ReadLine();
                //调用方法
                CalFather cal = GetCalFather(opera);
                double result = cal.GetResult(n1, n2);
                Console.WriteLine("最终结果是:{0}", result);
            }
        }

        /// <summary>
        /// 简单工厂设计模式
        /// </summary>
        /// <param name="opera"></param>
        /// <returns></returns>
        public static CalFather GetCalFather(string opera)
        {
            //创建一个父类保存返回结果
            CalFather cal = null;

            switch (opera)
            {
                case "+":
                    cal = new Add();
                    break;
                case "-":
                    cal = new Jian();
                    break;
                case "*":
                    cal = new Cheng();
                    break;
                case "/":
                    cal = new Chu();
                    break;
            }

            return cal;
        }
    }

    //abstract虚方法实现父类
    public abstract class CalFather
    {
        //属性
        public double NumOne { get; set; }

        //属性
        public double NumTwo { get; set; }

        //虚方法,计算结果
        public abstract double GetResult(int n1, int n2);

    }

    //加
    public class Add : CalFather
    {
        public override double GetResult(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    //减
    public class Jian : CalFather
    {
        public override double GetResult(int n1, int n2)
        {
            return n1 - n2;
        }
    }
    //乘
    public class Cheng : CalFather
    {
        public override double GetResult(int n1, int n2)
        {
            return n1 * n2;
        }
    }
    //除
    public class Chu : CalFather
    {
        public override double GetResult(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
