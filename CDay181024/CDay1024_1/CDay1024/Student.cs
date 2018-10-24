using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDay1024
{
    class Student
    {
        public  int no;
        string name;
        string classNo;
        static int counter = 0;
        public Student()
        {
            no= counter;
            counter++;
         }
        
    }
}