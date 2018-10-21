using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDay1016_1
{
    struct teacher
    {
        public int mum;
        public string name;
        public int age;
        public string banji;

        public void output()
        {
            Console.WriteLine("职工编号{0},姓名{0}，年龄{2}，所教班级{3}",mum,name,age,banji);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("请输入乘客人数");
            //    int count=int.Parse(Console.ReadLine());
            //    string[] names=new string[count];
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.WriteLine("请输入第{0}乘客姓名", i + 1);
            //        names[i] = Console.ReadLine();
            //    }
            //    Console.WriteLine("--------------------------------------------");
            //    foreach (string name in names)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            teacher s;
            s.mum = 22;
            s.name = "哈哈哈";
            s.age = 31;
            s.banji = "18数信1";
            s.output();




        }
    }
}
