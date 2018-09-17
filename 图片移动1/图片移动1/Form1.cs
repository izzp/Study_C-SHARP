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
        int v = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {      
            pictureBox1.Left += v * direct;
            if (pictureBox1.Left > this.Width - pictureBox1.Width)
            {
                direct = -1;
            }
            if (pictureBox1.Left < 0)
            {
                direct = 1;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {        
            pictureBox1.Top += v * direct;
            if (pictureBox1.Top > this.Height - pictureBox1.Height)
            {
                direct = -1;
            }
            if (pictureBox1.Top < 0)
            {
                direct = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if（ timer1.Enabled = true 
            {
            timer1.Enabled = false ;
            timer2.Enabled = false ;
            }        
        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            v += 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (v > 5)
            {
                v -= 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
        }


    }
}
