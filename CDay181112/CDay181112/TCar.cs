using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDay181112
{
    class TCar : Car
    {
        public TCar() 
        { 

        }
        void f() { Console.WriteLine("好啊好啊"); }
        public void haha() { base.ha(); f(); }

    }
}
