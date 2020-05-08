using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习_类的字段_属性_非法制限定
{
    public class Person
    {
        //姓名
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //年龄
        int _age;
        public int Age
        {
            get { return _age; }

            //对set进行限定
            set
            {
                //如果输入的年龄小于0或者大于100
                if (value < 0 || value > 100)
                {
                    //默认为18岁
                    value = 18;
                }
                _age = value;
            }
        }

        //性别
        char _gender;
        public char Gender
        {
            //对get进行限定
            get
            {
                //如果性别输入的既不是男也不是女
                if (_gender != '男' && _gender != '女')
                {
                    //默认为男
                    _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }

        //成绩
        int _score;
        public int Score
        {
            get { return _score; }
            set {  _score = value; }
        }

        //构造函数,在创建类的对象的时候写在后面的括号里面
        public Person(string name, int age, char gender, int score)
        {
            //在构造函数里面进行限定
            //如果成绩小于0
            if (score < 0)
            {
                //默认0分
                score = 0;
            }

            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //重载的构造函数
        public Person(string name, int age, char gender) : this(name, age, gender, 0)
        {

        }

        //方法:显示个人信息
        public void SayHello()
        {
            //this代表当前这个类
            Console.WriteLine("我是{0}，今年{1}岁，是{2}生,成绩{3}分", this.Name, this.Age, this.Gender, this.Score);
        }


    }
}
