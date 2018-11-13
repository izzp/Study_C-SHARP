using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDay181113_2
{
    class Student : Person, IHWC
    {
        int no;
        string myClass;
        public void HWC()
        {
            Console.WriteLine("求求你们快交作业吧");
        }
    }
}
