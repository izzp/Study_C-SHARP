using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图片移动1
{
    public partial class Form1 : Form
    {
        int direct = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 10 * direct;
            if (pictureBox1.Left > this.Width - pictureBox1.Width)
            {
                direct = -1;
            }
            if (pictureBox1.Left < 0)
            {
                direct = 1;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
