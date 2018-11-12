using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WNeonLight1
{
    public partial class Form1 : Form
    {
        public int style = 0;//1：一个移动 2：顺时针  3：逆时针
        const int N = 50;
        public int s = 0;     //状态
        Label[] lbls = new Label[N];
        Color[] colors = new Color[] { Color.Chocolate , Color.Pink, Color.Aqua , Color.Green, Color.Yellow };
        int j = 0;
        Color temp = new Color { };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorn_Click(object sender, EventArgs e)
        {
            for(int i=0;i<N;i++)
            {
                lbls [i] = new Label();            
                lbls [i].Size = new Size(30, 30);
                lbls[i].BackColor = colors[i % 5];
                if(i<15)
                {
                    lbls[i].Location=new Point(i*30,0);
                }
                else if(i<26)
                {
                    lbls[i].Location = new Point(420, (i-14)*30);
                }
                else  if (i < 40)
                {
                    lbls[i].Location = new Point((39-i)*30, 330);
                }
                else if (i < 50)
                {
                    lbls[i].Location = new Point(0, (50-i)*30);
                }
                panel1.Controls.Add(lbls[i]);
                s = 1;
            }
        }

        private void btnOneRun_Click(object sender, EventArgs e)//棕色运动
        {
            if(s==1)
            {
                timer1.Enabled = true;
                style = 1;
            }
            else
            {
                MessageBox.Show("请先生成");
            }
        }
        private void btnClockwise_Click(object sender, EventArgs e)//顺时针转圈
        {
            if (s == 1)
            {
                timer1.Enabled = true;
                style = 2;
            }
            else
            {
                MessageBox.Show("请先生成");
            }
        }
        private void btnCounterclockwise_Click(object sender, EventArgs e)//逆时针转圈
        {
            if (s == 1)
            {
                timer1.Enabled = true;
                style = 3;
            }
            else
            {
                MessageBox.Show("请先生成");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (style)
            {
                case 1: //一个运动
                        if (j == 0)
                        {
                            lbls[j].BackColor = Color.Orange;
                            lbls[49].BackColor = Color.Yellow;
                        } 
                        else
                        {
                            lbls[j - 1].BackColor = temp;
                        }
                        temp = lbls[j].BackColor;
                        lbls[j].BackColor = Color.Orange;
                        j = (j + 1) % 50;
                         break;
                case 2: //顺时针
                     for (int i = 0; i < N ; i++)
                    {
                        lbls[i].BackColor = colors[(j+i) % 5];
                    }
                    if(j>0)
                        j = (j -1) % 49;
                    else
                        j=-((j-1)%49);
                    break;
                case 3: //逆时针
                         for (int i = 0; i < N ; i++)
                        {
                            lbls[i].BackColor = colors[(i + j) % 5];
                        }
                        j = (j + 1) % 49;
                    break;
            }    
        }
    }
}
