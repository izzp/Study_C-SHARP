using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDay181113_2
{
    class Teacher : Person, IHWC
    {
        string rank;

        public void HWC()
        {
            Console.WriteLine("快交作业!");
        }
    }
}
