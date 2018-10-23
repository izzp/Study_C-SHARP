using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP108_5_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("请输入二维数组行数");
            while(!int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("输入非法，请重新输入");
            }
            int[ , ] intArr=new int [n,n];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine("请输入intArr[{0}]，[{1}]",i,j);
                     while(!int.TryParse(Console.ReadLine(),out intArr[i,j]))
                    {
                        Console.WriteLine("输入非法，请重新输入");
                    }
                }
              
            }
              Console.WriteLine("自定义数组输出");
              for(int i = 0 ; i < n ; i ++)
                {
                    for(int j=0;j<n;j++)
                    {
                            Console.Write("\t"+intArr[i,j]);
                    }
                    Console.WriteLine("");
                }
              int sum = 0;
              for (int i = 0; i < n; i++)
              {
                  for (int j = 0; j < n; j++)
                  {
                      if (i == j || i + j == n - 1)
                      {
                          sum += intArr[i, j];
                      }
                  }            
              }
              Console.WriteLine("对角线之和为{0}",sum);
        }
    }
}
