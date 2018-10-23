using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP108_5_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "线性代数", "c#", "sql", "Web前端设计与开发", "大学英语", "毛概", "体育" };
            foreach (string s in subjects)
            {
                Console.WriteLine(s);//输出所有的学科
            }

        }
    }
}
