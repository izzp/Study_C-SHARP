using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cint练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //解析int

            //1.测试最大值和最小值
            Console.WriteLine("int的取值范围是（{0}，{1}）",int.MinValue,int.MaxValue);

            //2.测试pares，缺点是不能识别字母
            Console.WriteLine("今年几岁了？");
            string strAge=Console.ReadLine();
            //int age=int.parse(strAge);
            //Console.WriteLine("我今年{0}岁了",age);

            //3.测试tyeParse
            
            //if的写法
            //int age = 0;
            //if (int.TryParse(strAge, out age))
            //{
            //    Console.WriteLine("我今年{0}岁了", age);
            //}
            //else
            //{
            //    Console.WriteLine("输入非法");
            //}


            //whlie的写法
            int age = 0;
            while (!int.TryParse(strAge, out age))
            {
                Console.WriteLine("输入非法字符，请重新输入");
                strAge = Console.ReadLine();
            }
            Console.WriteLine("我今年{0}岁了！", age);

        }
    }
}
