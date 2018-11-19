using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegate objDe =new Delegate();
            Class1 c1= new Class1();
            Class2 c2 =new Class2();
            objDe.haEvent+=new Delegate.haha(c1.display);
            objDe.haEvent+=new Delegate.haha(c2.display);
            objDe.Notify();
        }
    }
}
