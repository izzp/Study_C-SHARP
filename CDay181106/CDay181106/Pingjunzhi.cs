using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDay181106
{
    class Pingjunzhi
    {
        public double ave(params int[] array)
        {
            float Sum = 0; int Count = 0;
            foreach (float n in array)
            {
                Sum += n;
                Count += 1;
            }
            return Sum / Count;

        }
    }
}
