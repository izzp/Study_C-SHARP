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
            StreamWriter sw = new StreamWriter(@"../../注册.txt", true, Encoding.GetEncoding("gb2312"));
            try
            {
                if (this.txtRegistePassword.Text == txtRegistePassword2.Text)
                {
                    sw.WriteLine(this.txtRegisteName.Text + "\t" + this.txtRegistePassword.Text);
                    MessageBox.Show("注册成功");
                }
                else
                {
                    MessageBox.Show("两次密码不一致！");
                }
                sw.Close();
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
