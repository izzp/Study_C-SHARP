using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDay181114
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArr = new object[6];
            objArr[0]=new Class1();
            objArr[1]=new Class2();
            objArr[2]="hello";
            objArr[3]=123;
            objArr[4]=1.23;
            objArr[5]=null;
            for(int i=0;i<objArr.Length;i++)
            {
                string s =objArr[i] as string;
                Console.Write("{0} ",i);
                if (s != null)
                { Console.WriteLine( s + "是字符串"); }
                else
                { Console.WriteLine("不是一个字符串"); }
            }

        }
    }
}
