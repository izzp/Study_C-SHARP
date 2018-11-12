using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDay181106
{
    class class1
    {
        public void valdiliver(ref int i)
        {
            i += 5;
            Console.WriteLine(i);
        }
	public void valdiliver(class2 ob) 
	{
		ob.str+=" 还是哈哈哈";
		Console.WriteLine(ob.str);
	}
    }
}
