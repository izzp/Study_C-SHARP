using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLoginObject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.UserName = txtName.Text.Trim();
            u.Password = txtPassword.Text.Trim();
            if(FileOption.ReadFile(u.UserName))
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        private void btnRegiste_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
