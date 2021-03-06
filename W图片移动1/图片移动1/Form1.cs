﻿using System;
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
        int h = 1;
        int i = 0; 
        int v = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//左右移动按钮
        {
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)//上下移动按钮
        {
            timer1.Enabled = false;
            timer3.Enabled = false;
            timer2.Enabled = true;
        }
        private void button7_Click(object sender, EventArgs e)//环绕运动按钮
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = true;          
        }

        private void timer1_Tick(object sender, EventArgs e)//左右运动
        {    
            pictureBox1.Left += v * direct;
            if (pictureBox1.Right > this.Width)
            {
                direct = -1;
            }
            if (pictureBox1.Left < 0)
            {
                direct = 1;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)//上下运动
        {        
            pictureBox1.Top += v * direct;
            if (pictureBox1.Bottom > this.Height)
            {
                direct = -1;
            }
            if (pictureBox1.Top < 0)
            {
                direct = 1;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)//环绕运动
        {
            pictureBox1.Top += v * i;
            pictureBox1.Left += v * h;
           
            if (pictureBox1.Right > Width)
            {
                h = 0;
                i = 1;
                pictureBox1.Top += v * i;
            }
            if (pictureBox1.Bottom > Height)
            {
                h = -1;
                i = 0;              
            }
            if (pictureBox1.Left <0)
            {
                i = -1;
                h = 0;
            }
            if (pictureBox1.Top< 0)
            {
                h = 1;
                i = 0;
            }
        }
        private void button3_Click(object sender, EventArgs e)//暂停
        {
                timer1.Stop();  
                timer2.Stop();
                timer3.Stop();
        }
    
        private void button4_Click(object sender, EventArgs e)//加速
        {
            v += 10;
        }

        private void button5_Click(object sender, EventArgs e)//减速
        {
            if (v > 5)
            {
                v -= 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)//复位
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            v = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
