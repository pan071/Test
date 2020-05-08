using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //子类可以赋值给父类
            Person p = new Student("张三",20201);
            p.SayHello();

            //父类可以转换成子类(前提是父类里面放的是子类对象)
            Person p2 = new Student("李四", 20202);

            //as转换：转换成功返回对象,失败返回null
            Student s1 = p2 as Student;

            //is转换：成功返回true,失败返回false
            Person p3 = new Student("王五",20203);
            bool b  = p3 is Student;
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
        public void SayHello()
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

}
