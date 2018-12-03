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
            Regex name = new Regex(@"^[\u4e00-\u9fa5]{2,}");
            Regex age = new Regex(@"^(?:[1-9][0-9]?|1[01][0-9]|100)$");
            Regex Phone = new Regex(@"0?(13|14|15|18|17)[0-9]{9}$");
            Regex id = new Regex(@"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$");
            Regex mail = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            string s="";
            if (!name.IsMatch(lblName.Text.Trim()))
            {
                s = "姓名，";
                lblName.Visible = true;
            }
            if (!age.IsMatch(txtAge.Text.Trim()))
            {
                s = s+"年龄，"; 
                lblAge.Visible = true;
            }
            if (!Phone.IsMatch(lblPhone.Text.Trim()))
            {
                  s = s+"手机号码，"; 
                lblPhone.Visible = true;
            }
            if (!mail.IsMatch(lblMail.Text.Trim()))
            {
                s = s+"电子邮箱，"; 
                lblMail.Visible = true;
            }
            if (!id.IsMatch(lblID.Text.Trim()))
            {
                s =s+ "身份证号"; 
                lblID.Visible = true;
            }
            if (name.IsMatch(lblName.Text.Trim()) && age.IsMatch(txtAge.Text.Trim()) && Phone.IsMatch(lblPhone.Text.Trim()) && mail.IsMatch(lblMail.Text.Trim()) && id.IsMatch(lblID.Text.Trim()))
            {
                MessageBox.Show("提交成功！");
            }
            else
            {
                MessageBox.Show(s+"校验失败，请检查！");
            }

        }
    }
}
