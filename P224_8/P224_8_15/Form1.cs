using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P224_8_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==0)
            {
                textBox1.Text = "河北石家庄新乐";
            }
            else if (listBox1.SelectedIndex == 1)
            {
                textBox1.Text = "河北石家庄鹿泉";
            }
            else if (listBox1.SelectedIndex == 2)
            {
                textBox1.Text = "河北石家庄正定";
            }
            else if (listBox1.SelectedIndex == 3)
            {
                textBox1.Text = "河北石家庄元氏";
            }
            else if (listBox1.SelectedIndex == 4)
            {
                textBox1.Text = "河北邯郸大名";
            }
            else if (listBox1.SelectedIndex == 5)
            {
                textBox1.Text = "河北邯郸武安";
            }
            else if (listBox1.SelectedIndex == 6)
            {
                textBox1.Text = "河北邯郸磁县";
            }
            else if (listBox1.SelectedIndex == 7)
            {
                textBox1.Text = "河北邯郸丛台区";
            }
            else if (listBox1.SelectedIndex == 8)
            {
                textBox1.Text = "河北邯郸邯山区";
            }
            else if (listBox1.SelectedIndex == 9)
            {
                textBox1.Text = "河北邯郸高开区";
            }
           
        }
    }
}
