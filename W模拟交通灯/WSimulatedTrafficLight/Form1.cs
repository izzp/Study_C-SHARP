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
        int red_time, yellow_time, green_time, time = 0;  //定义红绿灯亮的时间
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("雨心Dream ");
        }

        private void textBoxRedLight_TextChanged(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择亮灯方式");
            }
            else
                switch (this.comboBox1.SelectedItem.ToString())
                {
                    case "红灯先亮":
                        {
                            if (red_time > time)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.r;
                                time++;
                                Text = "当前红灯亮了" + time + "秒";
                            }
                            else if (green_time > time - red_time && green_time > 0)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.g;
                                time++;
                                Text = "当前绿灯亮了" + (time - red_time) + "秒";
                            }
                            else if (yellow_time + green_time + red_time > time && yellow_time > 0)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.y;
                                time++;
                                Text = "当前黄灯亮了" + (time - red_time - green_time) + "秒";
                            }
                            else
                            {
                                time = 0;
                            };
                            break;
                        }
                    case "绿灯先亮":
                        {
                            if (green_time > time)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.g;
                                time++;
                                Text = "当前绿灯亮了" + time + "秒";
                            }
                            else if (yellow_time > time - green_time && yellow_time > 0)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.y;
                                time++;
                                Text = "当前黄灯亮了" + (time - green_time) + "秒";
                            }
                            else if (yellow_time + green_time + red_time > time && red_time > 0)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.r;
                                time++;
                                Text = "当前红灯亮了" + (time - yellow_time - green_time) + "秒";
                            }
                            else
                            {
                                time = 0;
                            };
                            break;
                        }
                    case "黄灯先亮":
                        {
                            if (yellow_time > time)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.y;
                                time++;
                                Text = "当前黄灯亮了" + time + "秒";
                            }
                            else if (red_time > time - red_time && green_time > 0)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.r;
                                time++;
                                Text = "当前红灯亮了" + (time - yellow_time) + "秒";
                            }
                            else if (yellow_time + green_time + red_time > time && green_time > 0)
                            {
                                pictureBox1.Image = WSimulatedTrafficLight.Properties.Resources.g;
                                time++;
                                Text = "当前绿灯亮了" + (time - red_time - yellow_time) + "秒";
                            }
                            else
                            {
                                time = 0;
                            };
                            break;
                        }
                    default:
                        break;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            timer1.Enabled = true;
        }

        private void RednumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GreennumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void YellonumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
