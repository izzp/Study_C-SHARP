using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDay181106
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 v1 = new class1();
            class2 v2 = new class2();
            int ii = 5;
            Console.WriteLine(ii);
            v1.valdiliver(ref ii);
            Console.WriteLine( ii);

            Console.WriteLine(v2.str);
            v1.valdiliver(v2); 
            Console.WriteLine(v2.str);


            Pingjunzhi a = new Pingjunzhi();
           Console.WriteLine( a.ave(1,2,34,567));

        }
    }
}
