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
    public partial class Registe : Form
    {
        public Registe()
        {
            InitializeComponent();
        }

        private void btnegiste_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\users.xml"))//注册
            {
                bool s = false;
                XElement users = XElement.Load(@"..\..\users.xml");
                foreach (var v in users.Elements())
                {
                    if (v.Element("name").Value == this.txtRegisteName.Text.Trim())
                    {
                        MessageBox.Show("用户已存在！");
                        s = false;
                        return;
                    }
                    else
                    {
                        s = true;
                    }
                }
                if (s)
                {
                    if (txtRegisteName.Text.Trim() != null && txtRegistePassword.Text.Trim() != null)
                    {
                        if (txtRegistePassword.Text.Trim() == txtRegistePassword2.Text.Trim())//判断两次密码是否一致
                        {         
                            users.Add(new XElement("user",
                                new XElement("name", txtRegisteName.Text.Trim()),
                                new XElement("password", txtRegistePassword.Text.Trim())
                                                    )
                                     );
                            users.Save(@"..\..\users.xml");
                            MessageBox.Show("注册成功");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("两次密码不一致，清重新输入");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请把信息填写完整");
                    }
                }
            }
            else//没有users.xml时执行
            {
                if (txtRegisteName.Text.Trim() != null && txtRegistePassword.Text.Trim() != null)
                {
                    if (txtRegistePassword.Text.Trim() == txtRegistePassword2.Text.Trim())//判断两次密码是否一致
                    {
                        XElement users = new XElement(new XElement("user",
                                          new XElement("name", txtRegisteName.Text.Trim()),
                                          new XElement("password", txtRegistePassword.Text.Trim())
                                                                   )
                                                      );
                        users.Save(@"..\..\users.xml");
                        MessageBox.Show("注册成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("两次密码不一致，清重新输入");
                    }
                }
                else
                {
                    MessageBox.Show("请把信息填写完整");
                }

            }
        }
    }
}
