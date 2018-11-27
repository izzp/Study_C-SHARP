using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CGeneric
{
    class Program
    {
        static void Main(string[] args)//泛型集合
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            //ints.Add("haha");
            foreach(object o in ints)
            {
                Console.WriteLine(o);
            }

            List<string> s = new List<string>();
            s.Add("haha");
            //s.Add(1);


            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "haha");
             students.Add(2,"ha");

            foreach (string c in students.Values)
            {
                Console.WriteLine(c);
            }
            foreach (DictionaryEntry de in students)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }



        }
    }
}
