using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdelegate
{
    class Program
    {
        delegate int haha(int a, int b);
        static void Main(string[] args)
        {
            Class1 c=new Class1();
            haha ha=new haha(c.add);
            Console.WriteLine(ha(5,7));

        }
    }
}
