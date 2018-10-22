using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSimulatedTrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int light = 3;//1绿灯亮，2黄灯亮，3红灯亮。
        int red_time, yellow_time, green_time; //定义红绿灯亮的时间
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("雨心Dream ");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (light)
            {
                case 1://绿灯亮
                    this.Text = "绿灯亮了" + i + "秒！";
                    pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.g;
                    if (i == green_time)
                    {
                        light = 2;
                        i = 0;
                    }
                    i++;
                    break;
                case 2://黄灯亮
                    this.Text = "黄灯亮了" + i + "秒！";
                    pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.y;
                    if (i == yellow_time)
                    {
                        light = 3;
                        i = 0;
                    }
                    i++;
                    break;
                case 3://红灯亮
                    this.Text = "红灯亮了" + i + "秒！";
                    pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.r;
                    if (i == red_time)
                    {
                        light = 1;
                        i = 0;
                    }
                    i++;
                    break;
                default: break;
            }  
        }
        private void EixtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            red_time = (int)this.RednumericUpDown.Value;
            yellow_time = (int)this.YellonumericUpDown.Value;
            green_time = (int)this.GreennumericUpDown.Value;     //获取时间
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择亮灯方式");
            }
            else
            {
                light = comboBox1.SelectedIndex+1;
                timer1.Enabled = true;
            }
            if(red_time==0|| yellow_time==0|| green_time==0)
            {
                 MessageBox.Show("输入数字要大于0");
                 timer1.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "请选择";
            red_time = 0;
            yellow_time = 0;
            green_time = 0;
            timer1.Enabled = false;
            pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.nrgy;
            this.Text = "模拟交通灯";
        }
    }
}
