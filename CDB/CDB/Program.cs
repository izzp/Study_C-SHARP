using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CDB
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=506-63;Initial Catalog=teaching;Integrated Security=True");
                conn.Open();
                //增
                //SqlCommand comm = new SqlCommand("insert into student values('s8','哈哈哈','M',24)", conn);
                //if(comm.ExecuteNonQuery() >0)
                //{
                //    Console.WriteLine("插入成功");
                //}
                //else
                //{
                //    Console.WriteLine("插入失败");
                //}

                //删
                //SqlCommand comm = new SqlCommand("delete from student where sno='s8'", conn);
                //if (comm.ExecuteNonQuery() > 0)
                //{
                //    Console.WriteLine("删除成功");
                //}
                //else
                //{
                //    Console.WriteLine("删除失败");
                //}
              
                //改
                SqlCommand comm = new SqlCommand("update student set age =21 where sno='s7'", conn);
                if (comm.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("更改成功");
                }
                else
                {
                    Console.WriteLine("更改失败");
                }

                //查
                //SqlCommand comm = new SqlCommand("select * from student", conn);
                //SqlDataReader reader = comm.ExecuteReader();
                //if(reader.HasRows)
                //{
                //    while(reader.Read())
                //    {
                //        Console.WriteLine("学号：{0}，姓名：{1}，性别：{2}，年龄：{3}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3));
                //    }
                //}
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
