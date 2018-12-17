using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P224_8_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                textBox1.Font = new Font("宋体", 9,  FontStyle.Underline);
            }
            else if (checkBox1.Checked == false && checkBox2.Checked==true)
            {
                textBox1.Font = new Font( "宋体",9, FontStyle.Strikeout);
            }
            else if (checkBox2.Checked == true && checkBox2.Checked == true)
            {
                textBox1.Font = new Font("宋体", 9, FontStyle.Strikeout | FontStyle.Underline);
            }
            else 
            {
                textBox1.Font = new Font("宋体", 9);
            }
        }
    }
}
