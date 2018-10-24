using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDay1024_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add x=new Add();
            Console.WriteLine(x.and(1, 2));
            Console.WriteLine(x.and(1.1, 2.1));
        }
    }
}
