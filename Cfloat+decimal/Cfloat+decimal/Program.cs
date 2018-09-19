using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cfloat_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试float
            Console.WriteLine(float.Epsilon);
            Console.WriteLine(float.IsInfinity(999999999f));
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.NaN);
            Console.WriteLine(float.IsNaN(float.NaN));
            float f = 0f;
            if (float.TryParse("1.234f", out f)) 
            {
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("转换失败");
            }


            //测试decimal
            Console.WriteLine(decimal.MinusOne);
            Console.WriteLine(decimal.Add(1.2m, 3.4m));
            decimal d = 1.2m + 3.4m;
            Console.WriteLine(d);
            int[] bits;
            bits = decimal.GetBits(9);
            //Console.WriteLine("{0,10:B8}", bits[0]);
            Console.WriteLine(decimal.Remainder(10, 3));
            Console.WriteLine(decimal.Round(4.50m));
            Console.WriteLine(decimal.ToInt32(3.6m));
            string s = "abc123,utriweoueio,549032509,u54u2iwjkl,u4io32utri4ou,fdsa";
            Console.WriteLine(s.Contains('q'));
            Console.WriteLine(s.ToUpper());
            string[] ss = s.Split(',');
            for (int i = 0; i < ss.Length; i++)
            {
                Console.WriteLine(ss[i]);
            }
        }
    }
}
