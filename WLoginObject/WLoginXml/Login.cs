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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.UserName = txtUserName.Text.Trim();
            u.Password = txtPassword.Text.Trim();
            if(FileOption.readFile(u))
            {
                MessageBox.Show("登录成功！", "欢迎", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("登录失败！", "很遗憾", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
