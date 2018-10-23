using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP108_5_3_3
{
        struct stduents
        {
            public int mum;
            public string name;
            public int age;
            public string xinbie;

            public void output()
            {
                Console.WriteLine("学号{0},姓名{1}，年龄{2}，性别{3}", mum, name, age, xinbie);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                stduents s;
                s.mum = 22;
                s.name = "哈哈哈";
                s.age = 20;
                s.xinbie = "男";
                s.output();
            }
        }
}
