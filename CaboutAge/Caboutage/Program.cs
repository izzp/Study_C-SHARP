using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caboutage
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 20;
            Console.WriteLine("小老弟你好啊，我今年{0}岁，你今年几岁啦？",myAge);
            string strAge=Console.ReadLine();
            int age=0;
            while (!int.TryParse(strAge,out age))
            {
                Console.WriteLine("输入非法字符，请重新输入");
                strAge=Console.ReadLine();
            }
            Console.WriteLine("我今年{0}岁了！",age);
            if (myAge - age > 0)
            {
                Console.WriteLine("我比你大{0}岁", myAge - age);
            }
            else
                Console.WriteLine("那你比我大");
        }
    }
}
