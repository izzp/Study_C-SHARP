using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStack
{ 
    class Program
    {
        //堆栈
        static void Main(string[] args)
        {
            Stack s=new Stack();
            s.Push("哈哈");
            s.Push("张三");
            s.Push("李四");
            s.Push("王五");
            foreach(object o in s)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("栈顶是" + s.Peek());
            if(s.Contains("张三"))
            {
                Console.WriteLine("张三在栈中");
            }
            else
            {
                Console.WriteLine("张三不在栈中");
            }
        }
    }
}
