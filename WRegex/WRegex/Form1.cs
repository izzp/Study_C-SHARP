using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"注册.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            Regex name = new Regex(@"^[\u4e00-\u9fa5]{2,}");
            Regex age = new Regex(@"^(?:[1-9][0-9]?|1[01][0-9]|100)$");
            Regex Phone = new Regex(@"0?(13|14|15|17|18|19)[0-9]{9}");
            Regex id = new Regex(@"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$");
            Regex mail = new Regex(@"\w[-\w.+]*@([A-Za-z0-9][-A-Za-z0-9]+\.)+[A-Za-z]{2,14}");
            string s="";
            if (!name.IsMatch(txtName.Text.Trim()))
            {
                s = "姓名，";
                lblName.Visible = true;
            }
            else
            {
                lblName.Visible = false;
            }
            if (txtGender.Text != "男" && txtGender.Text != "女")
            {
                s = s+"性别，";
                lblGender.Visible = true;
            }
            else
            {
                lblGender.Visible = false;
            }
            if (!age.IsMatch(txtAge.Text.Trim()))
            {
                s = s+"年龄，"; 
                lblAge.Visible = true;
            }
            else
            {
                lblAge.Visible = false;
            }
            if (!Phone.IsMatch(txtNum.Text.Trim()))
            {
                  s = s+"手机号码，"; 
                lblPhone.Visible = true;
            }
            else
            {
                lblPhone.Visible = false;
            }
            if (!mail.IsMatch(txtMail.Text.Trim()))
            {
                s = s+"电子邮箱，"; 
                lblMail.Visible = true;
            }
            else
            {
                lblMail.Visible = false;
            }
            if (!id.IsMatch(txtID.Text.Trim()))
            {
                s =s+ "身份证号"; 
                lblID.Visible = true;
            }
            else
            {
                lblID.Visible = false;
            }
            if (lblAge.Visible || lblID.Visible || lblMail.Visible || lblName.Visible || lblPhone.Visible)
            {
                MessageBox.Show(s + "校验失败，请检查！");
            }
            else
            {
                try
                {
                    sw.WriteLine("姓名：" + this.txtName.Text + "\r\n性别：" + this.txtGender.Text + "\r\n年龄：" + this.txtAge.Text + "岁\r\n手机号码为：" + this.txtNum.Text + "\r\n邮箱为：" + this.txtMail.Text + "\r\n身份证号为：" + this.txtID.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
                MessageBox.Show("提交成功！文件写入成功！");
            }

        }
    }
}
