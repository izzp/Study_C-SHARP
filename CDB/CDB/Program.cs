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
                Console.WriteLine("数据库连接成功");
                SqlCommand comm = new SqlCommand("select * from student", conn);
                SqlDataReader reader = comm.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Console.WriteLine("学号：{0}，姓名：{1}，性别：{2}，年龄：{3}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt16(3));
                    }
                }
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
