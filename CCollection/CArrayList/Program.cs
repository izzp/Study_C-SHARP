using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add(35);
            a.Add(5);
            a.Add(7);
            //a.Sort();//排序
            a.Remove(35);
            a.Insert(0, 6);
            a.Add(DateTime.Now);
            Console.WriteLine("该列表有{0}个元素", a.Count);

            foreach (object o in a)
            {
                Console.WriteLine(o);
            }
        }
    }
}
