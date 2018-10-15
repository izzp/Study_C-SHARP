using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP86_4_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; //定义一个变量接收能被3整除但不能被5整除的数的个数
            for (int i = 1; i <= 100;i++ ) 
            {
            if (i % 3 == 0 && i % 5 != 0) 
              {
                sum = sum + 1;
                Console.WriteLine(i);
              }
            }
            Console.WriteLine("共有{0}个这样的数",sum);
        }
    }
}
