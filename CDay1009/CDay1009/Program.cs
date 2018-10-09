using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDay1009
{
    class Program
    {

        static void Main(string[] args)
        {
            //    string s = ("hello ha ha ha ha");
            //    foreach(char c in s)
            //    {
            //        Console.WriteLine(c);
            //    }
            //}
            int a = 0, b = 0, c = 0, d = 0;//a数字，b字母，c符号，d其它
            string s = Console.ReadLine();
            foreach (char ch in s)
            {
                if (char.IsDigit(ch))
                    a++;
                else if (char.IsLetter(ch))
                    b++;
                else if (char.IsPunctuation(ch))
                    c++;
                else
                    d++;
            }
            Console.WriteLine("数字有{0}个，字母有{1}个，符号有{2}个，其他字符有{3}个。", a, b, c, d);
        }
    }
}
