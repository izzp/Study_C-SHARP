using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPictureMove
{
    public partial class Form1 : Form
    {
        int a=1;//环周运动时指定图片在哪个边上运动，1：上边，2：右边，3：下边，4：左边

        int style = 1;//指定运动方式，1：左右，2：上下，3：环周

        int step = 1;//步长

        int v =10;//基础速度倍数，不然速度太慢...
        
        public Form1()
        {
            InitializeComponent();
        }
        private void btnUpDown_Click(object sender, EventArgs e)//上下运动
        {
            timer1.Enabled = true;
            style = 2;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            
        }

        private void btnLeftRight_Click(object sender, EventArgs e)//左右运动
        {
            timer1.Enabled = true;
            style = 1;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
        }
        private void btnCircle_Click(object sender, EventArgs e)//环周
        {
            timer1.Enabled = true;
            style = 3;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "当前位置：（" + pictureBox1.Left + "，" + pictureBox1.Top + "）";
            switch (style)
            {
                case 1://左右
                    {
                        this.Text = "正在做左右运动，速度为:" + 1000 / timer1.Interval + "";
                        pictureBox1.Left += step * v;
                        if (pictureBox1.Right > this.Width)
                        {
                            step = -1;
                        }
                        if (pictureBox1.Left < 0)
                        {
                            step = 1;
                        }

                    }
                    break;
                case 2://上下
                    {
                        this.Text = "正在做上下运动，速度为:" + 1000 / timer1.Interval + "";
                        pictureBox1.Top += v * step;
                        if (pictureBox1.Top > this.Height-2*pictureBox1.Height)
                        {
                            step = -1;
                        }
                        if (pictureBox1.Top < 0)
                        {
                            step = 1;
                        }
                    }
                    break;
                case 3://环周
                    {
                        this.Text = "正在做环周运动，速度为:" + 1000 / timer1.Interval + "";
                        if (a == 1)//上边
                        {
                            if (pictureBox1.Left < this.Width - pictureBox1.Width-20)
                            {
                                pictureBox1.Left += step*v;
                            }
                            else
                            {
                                a = 2;
                            }
                        }
                        if (a == 2)//右边
                        {
                            if (pictureBox1.Top < this.Height - pictureBox1.Height-40)
                            {
                                pictureBox1.Top += step*v;
                            }
                            else
                            {
                                a = 3;
                            }
                        }
                        if (a == 3)//下边
                        {
                            if (pictureBox1.Left > 0)
                            {
                                pictureBox1.Left -= step*v;
                            }
                            else
                            {
                                a = 4;
                            }
                        }
                        if (a == 4)//左边
                        {
                            if (pictureBox1.Top > 0)
                            {
                                pictureBox1.Top -= step*v;
                            }
                            else
                            {
                                a = 1;
                            }
                        }
                        break;
                    }
                
            }
        }

        private void btnSpeedUp_Click(object sender, EventArgs e)//加速
        {
            btnSpeedDown.Enabled = true;
            if (timer1.Interval > 1)
            {
                timer1.Interval = timer1.Interval / 2;
            }
            else
            {
                btnSpeedUp.Enabled = false;
            }
        }
        private void btnSpeedDown_Click(object sender, EventArgs e)//减速
        {
            btnSpeedUp.Enabled = true;
            if (timer1.Interval <999)
            {
                timer1.Interval = timer1.Interval * 2;
            }
            else
            {
                btnSpeedDown.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)//复位
        {
            timer1.Enabled = false;
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            timer1.Interval = 100;
        }
        private void btnWindowsBig_Click(object sender, EventArgs e)//窗口变大
        {
            this.Width += 50;
            this.Height += 25;
        }
        private void btnWindowsSmall_Click_1(object sender, EventArgs e)//窗口变小
        {
            this.Width -= 50;
            this.Height -= 25;
        }

        private void Form1_Resize(object sender, EventArgs e)//窗口变大或缩小的同时，使运动图片跟随
        {
            if (a == 2 && style == 3)
            {
                pictureBox1.Left = this.Width - pictureBox1.Width - 10;
            }
            if (a == 3 && style == 3)
            {
                pictureBox1.Top = this.Height - pictureBox1.Height - 30;
            }
        }
    }
}
