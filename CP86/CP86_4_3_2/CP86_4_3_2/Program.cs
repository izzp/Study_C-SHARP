using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP86_4_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, k, n = 0;
            for (m = 2; m <= 1000; m++)
            {
                for (k = 2; k < m; k++)
                    if (m % k == 0)
                        break;
                if (k >= m)
                {
                    Console.WriteLine("{0}", m);
                    if (++n % 10 == 0)
                        Console.WriteLine("\n");
                }
            }
        }
    }
}
