using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string gender;
            string hobby="";
            string course="";
            if (rbtnM.Checked)
                gender = rbtnM.Text;
            else
                gender = rbtnF.Text;
            if(chkSleep.Checked)
                hobby+=chkSleep.Text;
            if(chkGame.Checked)
                hobby+=chkGame.Text;
             if(chkSing.Checked)
                hobby+=chkSing.Text;
            foreach(object o in checkedListBox1.CheckedItems)
            {
                course+=o.ToString();
            }
            MessageBox.Show("姓名"+name + "，性别" + gender+"，爱好" + hobby +"，学了"+ course);
        }
    }
}
