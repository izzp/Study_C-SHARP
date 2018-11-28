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
            string myclass;
            string hobby="";
            string course="";
            string club = "";
            if (rbtnM.Checked)//性别
                gender = rbtnM.Text;
            else
                gender = rbtnF.Text;
            if (rbtnClassOne.Checked)//班级
                myclass = rbtnClassOne.Text;
            else
                myclass = rbtnClassTwo.Text;
            if(chkSleep.Checked)//爱好
                hobby+=chkSleep.Text;
            if(chkGame.Checked)
                hobby+=chkGame.Text;
             if(chkSing.Checked)
                hobby+=chkSing.Text;
            foreach(object o in checkedListBox1.CheckedItems)//课程
            {
                course+=o.ToString();
            }
            foreach(object o in listBoxClub.SelectedItems)//社团
            {
                club += o.ToString();
            }
            MessageBox.Show("姓名"+name + "，性别" + gender+"，班级"+myclass+"，爱好" + hobby +"，学了"+ course+"，报了"+club);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
