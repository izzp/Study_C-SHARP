using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDir
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件与文件夹得相关操作
            //Directory.CreateDirectory(@"c:\\abc");
            //Directory.CreateDirectory(@"c:\\abc\abc");
            //  Directory.Delete(@"c:\\abc\abc");
            //Directory.Move(@"c:\\abc", "c:\\ab");
            //Directory.Exists(@"c:\\abc");
            //string[] str = Directory.GetFiles("c:\\");
            //foreach(string s in str)
            //{
            //    Console.WriteLine(s);
            //}


            DirectoryInfo dir = new DirectoryInfo(@"c:\\abc");
            //dir.Create();
            //dir.Delete();

            File.Create(@"c:\\a.txt");
            FileInfo f = new FileInfo(@"c:\\a.txt");
            Console.WriteLine(f.Length);


        }
    }
}
