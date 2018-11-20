using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable student =new Hashtable();
            student.Add(1,"杨蕾");
            student.Add(2,"任则含");
            student.Add(3,"牛梦涵");
            student[1] = "哈哈";
            foreach(int i in student.Keys)
            {
                Console.WriteLine(i);
            }
            foreach(string s in student.Values)
            {
                Console.WriteLine(s);
            }
            foreach(DictionaryEntry de in student)
            {
                Console.WriteLine(de.Key+","+de.Value);
            }
        }
    }
}
