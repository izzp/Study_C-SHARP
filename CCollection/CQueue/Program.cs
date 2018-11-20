using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQueue
{
    class Program
    {
        //队列
        static void Main(string[] args)
        {
            Queue q=new Queue();
            q.Enqueue("张三");
            q.Enqueue("李四");
            q.Enqueue("王五");
            Console.WriteLine("队列中共有{0}人",q.Count);
            if(q.Contains("张三"))
            {
                Console.WriteLine("张三在队中");
            }
            foreach(object o in q)
            {
                Console.WriteLine(o);
            }
        }
    }
}
