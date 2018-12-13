using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WLoginObject
{
    class FileOption
    {
        static string path = @"../../users.txt";
        /// <summary>
        /// 写入用户信息
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        static public bool WritFile(Users u)
        {
            bool result = false;
            StreamWriter sw=null;
            string line = u.UserName + "\t" + u.Password;
            try
            {
                sw = new StreamWriter(path,true,Encoding.GetEncoding("utf-8"));
                sw.WriteLine(line);
                result = true;   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw.Close();
            }
            return result;
        }
        /// <summary>
        /// 去读取用户信息
        /// </summary>
        /// <param name="u">要读取的用户信息</param>
        /// <returns></returns>
        static public bool ReadFile(Users u)
        {
            bool result = false;
            StreamReader sr=null;
            try
            {
               sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
                string line;
                    string[] str;
                    while ((line = sr.ReadLine()) != null)
                    {
                        str = line.Split('\t');
                        if (str[0] == u.UserName&&str[1]==u.Password)
                        {
                             result = true;
                        }

                     }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sr.Close();
            }
            return result;
        }

        static public bool ReadFile(string UserName )
        {
            bool result = false;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path, Encoding.GetEncoding("utf-8"));
                string line;
                string[] str;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.Split('\t');
                    if (str[0] == UserName)
                    {
                        result = true;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sr.Close();
            }
            return result;
        }

    }
 }

