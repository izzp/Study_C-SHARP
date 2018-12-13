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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnegiste_Click(object sender, EventArgs e)
        {
            if(txtRegistePassword.Text.Trim()==txtRegistePassword2.Text.Trim())
            {
                return;
            }
            Users u=new Users();
            u.UserName=txtRegisteName.Text.Trim();
            u.Password=txtRegistePassword.Text.Trim();
            if(FileOption.WritFile(u))
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
