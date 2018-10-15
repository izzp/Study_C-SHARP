using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP86_4_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            //int sum = 0;
            //int i, num;
            //Console.WriteLine("请你输入要计算的第N个整数:");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i <= num; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("你要的N个数的和为:{0}", sum);
            //Console.ReadLine();

            //while
            //int sum = 0;
            //int i = 1, num;
            //Console.WriteLine("请你输入要计算的第N个整数:");
            //num = Convert.ToInt32(Console.ReadLine());
            //while (i <= num)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("你要的N个数的和为:{0}", sum);
            //Console.ReadLine();

            //do……while
            int sum = 0;
            int i = 1, num;
            Console.WriteLine("请你输入要计算的第N个整数:");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                sum += i;
                i++;
            } while (i <= num);
            Console.WriteLine("你要的N个数的和为:{0}", sum);
            Console.ReadLine();
        }
    }
}
