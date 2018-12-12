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
using System.Xml.Linq;

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
                XElement users= XElement.Load(@"..\..\users.xml");
                foreach (var v in users.Elements())
                {
                    if (v.Element("user").Value ==this.txtName.Text&&v.Element("password").Value ==this.txtPassword.Text)
                    {
                        MessageBox.Show("登录成功");
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

        private void btnRegiste_Click(object sender, EventArgs e)
        {
            btnRegisteRegiste re = new btnRegisteRegiste();
            re.Show();
        }
    }
}
