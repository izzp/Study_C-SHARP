using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLogin
{
    public partial class btnRegisteRegiste : Form
    {
        public btnRegisteRegiste()
        {
            InitializeComponent();
        }

        private void btnegiste_Click(object sender, EventArgs e)
        {

            try
            {
                string line;
                string[] str;
                bool s = true;
                StreamReader sr = new StreamReader(@"../../注册.txt", Encoding.GetEncoding("gb2312"));
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.Split('\t');
                    
                    if (str[0] == txtRegisteName.Text.Trim())
                    {
                        MessageBox.Show("用户已存在！");
                        s = true;
                        return;
                    }
                    else
                    {
                        s = false;
                    }
                    
                }
                sr.Close();
                if(s==false)
                {
                    if (this.txtRegistePassword.Text == txtRegistePassword2.Text)
                        {
                            StreamWriter sw = new StreamWriter(@"../../注册.txt", true, Encoding.GetEncoding("gb2312"));
                            sw.WriteLine(this.txtRegisteName.Text + "\t" + this.txtRegistePassword.Text);
                            MessageBox.Show("注册成功");
                            sw.Close();
                        }
                        else
                        {
                            MessageBox.Show("两次密码不一致！");
                        }
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
