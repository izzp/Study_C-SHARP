using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEvent
{
    class Delegate
    {
        public delegate void haha();
        public event haha haEvent;
        public void Notify()
        {
            haEvent();
        }
    }
}
