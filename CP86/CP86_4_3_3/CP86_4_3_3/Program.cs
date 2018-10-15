using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP86_4_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= new int[10];
            for (int x = 0; x < 4; x++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int i = 0; i <4; i++)
                {
                    if (array[i] == 0)
                    {
                        array[i] = number;
                        break;
                    }
                }
            }
            Console.WriteLine("最大值为{0}",array.Max());
            Console.WriteLine("最小值为{0}",array.Min());
        }
    }
}

