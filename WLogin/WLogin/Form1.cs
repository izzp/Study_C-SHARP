using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLoagin_Click(object sender, EventArgs e)
        {     
            try
            {
                StreamReader sr = new StreamReader(@"../../注册.txt", Encoding.GetEncoding("gb2312"));
                string line;
                string[] str;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.Split('\t');
                    if (str[0] == txtName.Text.Trim())
                    {
                        if (str[1] == txtPassword.Text.Trim())
                        {
                            MessageBox.Show(" 登录成功");
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误");
                        }
                    }
                    
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void btnRegiste_Click(object sender, EventArgs e)
        {
            btnRegisteRegiste re = new btnRegisteRegiste();
            re.Show();
        }
    }
}
