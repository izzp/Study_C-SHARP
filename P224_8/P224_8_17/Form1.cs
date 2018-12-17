using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P224_8_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                textBox1.Text = "13333333333";
                textBox2.Text = "石家庄";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "176666666666";
                textBox2.Text = "邯郸";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "13999999999";
                textBox2.Text = "唐山";
            }
        }
    }
}
