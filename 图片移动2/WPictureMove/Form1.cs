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
        int a=1;//指定图片在哪个边上运动，1：上边，2：右边，3：下边，4：左边

        int style = 1;//指定运动方式，1：左右，2：上下，3：环周

        int step = 1;//步长
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//环周
        {
            timer1.Enabled = true;
            style = 3;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
            this.Text = "正在做环周运动";
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "当前位置：（" + pictureBox1.Left + "，" + pictureBox1.Top + "）";
            switch (style)
            {
                case 1: MessageBox.Show("左右运动"); break;
                case 2: MessageBox.Show("上下运动"); break;
                case 3:
                    {
                        if (a == 1)//上边
                        {
                            if (pictureBox1.Left < this.Width - pictureBox1.Width)
                            {
                                pictureBox1.Left += step;
                            }
                            else
                            {
                                a = 2;
                            }
                        }
                        if (a == 2)//右边
                        {
                            if (pictureBox1.Top < this.Height - pictureBox1.Height)
                            {
                                pictureBox1.Top += step;
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
                                pictureBox1.Left -= step;
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
                                pictureBox1.Top -= step;
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

        private void button2_Click(object sender, EventArgs e)
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

        private void btnUpDown_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            style = 2;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
        }

        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            style = 1;
            pictureBox1.Left = 0;
            pictureBox1.Top = 0;
        }

        private void btnSpeedDown_Click(object sender, EventArgs e)
        {
            btnSpeedUp.Enabled = true;
            if (timer1.Interval <1000)
            {
                timer1.Interval = timer1.Interval * 2;
            }
            else
            {
                btnSpeedDown.Enabled = false;
            }
        }
    }
}
