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
using System.Xml.Linq;

namespace WLoginXml
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\users.xml"))//登陆
            {
                try
                {
                    bool a=true;//定义一个用户不存在时的状态
                    XElement users = XElement.Load(@"..\..\users.xml");
                    foreach (var v in users.Elements())
                    {
                        
                        if (v.Element("name").Value == this.txtName.Text)
                        {
                            if (v.Element("password").Value == this.txtPassword.Text)
                            {
                                MessageBox.Show("登录成功");
                                a = false;
                                return;
                            }
                            else
                            {
                                MessageBox.Show("密码错误！");
                                return;
                            }
                        }
                        else
                        {
                                a = true;
                         }
                        
                    }
                    if(a)
                    {
                        MessageBox.Show("此用户不存在，请返回注册或重试！");
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
            else
            {
                MessageBox.Show("users不存在！,请注册");
            }
        }

        private void btnRegiste_Click(object sender, EventArgs e)
        {
            Registe re = new Registe();
            re.Show();
        }
    }
}
