using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WLogin
{
    class DBOption
    {
        static public bool writeDB(Users u)
        {
            bool result = false;
            SqlConnection conn = null;
            SqlCommand comm = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-8PIQO9B;Initial Catalog=users;Integrated Security=True");
                conn.Open();
                comm = new SqlCommand("INSERT INTO users VALUES ('" + u.UserName + "','" + u.Password + "')", conn); 
                if (comm.ExecuteNonQuery() > 0)
                {
                    result = true;                  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        static public bool readDB(Users u)
        {
            bool result = false;
            SqlConnection conn = null;
            conn = new SqlConnection(@"Data Source=DESKTOP-8PIQO9B;Initial Catalog=users;Integrated Security=True");
            conn.Open();
            try
            {
                SqlCommand comm = new SqlCommand("select * from users", conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == u.UserName && reader.GetString(1) == u.Password)
                        {
                            result = true;
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;

        }

        static public bool readDB(string userName)
        {
            bool result = false;
            SqlConnection conn = null;
            conn = new SqlConnection(@"Data Source=DESKTOP-8PIQO9B;Initial Catalog=users;Integrated Security=True");
            conn.Open();
            try
            {
                SqlCommand comm = new SqlCommand("select * from users", conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == userName)
                        {
                            result = true;
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        static public bool updateDB(Users u)
        {
            bool result = false;
            SqlConnection conn = null;
            conn = new SqlConnection(@"Data Source=DESKTOP-8PIQO9B;Initial Catalog=users;Integrated Security=True");
            conn.Open();
            try
            {
                SqlCommand comm = new SqlCommand("update users set Password = '" + u.Password + "' where UserName = '" + u.UserName + "'", conn);
                if (comm.ExecuteNonQuery() > 0)
                {
                    result = true;
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}

