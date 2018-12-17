using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLogin
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致！");
                return;
            }
            Users u = new Users();
            u.UserName = txtUserName.Text.Trim();
            u.Password = txtPassword.Text.Trim();
            if (FileOption.readFile(u.UserName))
            {
                MessageBox.Show("当前用户已被注册！");
            }
            else
            {
                if (FileOption.writerFile(u))
                    MessageBox.Show("注册成功！");
                else
                    MessageBox.Show("注册失败！");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
        }
    }
}
