using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承和多态
{
    class Program
    {
        static void Main(string[] args)
        {

            //继承两大特性
            //1、单根型：一个子类只能有一个父类
            //2、传递性：一个父类可以被子类继承，子类的子类也可以继承
        }
    }

    //父类
    public class Person
    {

        //属性
        public string Name
        {
            get;
            set;
        }

        //方法
        public void SayHello(string name)
        {
            Console.WriteLine("我是{0}", this.Name);
        }

        //构造函数
        public Person(string name)
        {
            this.Name = name;
        }
    }

    //子类
    public class Student : Person
    {
        //子类继承了父类的属性和方法

        //只写自己的属性就可以了
        public int ID
        {
            get;
            set;
        }

        //没有继承构造函数,但是可以调用父类的构造函数
        public Student(string name, int id) : base(name)
        {
            //只需要给自己独有的属性进行赋值
            this.ID = id;
        }
    }

    //子类的子类
    public class Test:Student
    {
        public double Salary
        {
            get;
            set;
        }

        //可以直接使用父类的属性
        public Test(string name,double salary):base("张三",6666)
        {
            this.Salary = salary;
        }
    }

}
