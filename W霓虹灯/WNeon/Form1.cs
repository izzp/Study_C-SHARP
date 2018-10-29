using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WNeon
{
    enum Direction
    {
        right,
        down,
        left,
        up,
    }
    public partial class Form1 : Form
    {
        const int N = 5;
        Label[] labs = new Label[N];
        Color[] colors = new Color[5] { Color.Cyan, Color.Red, Color.Pink, Color.Yellow, Color.Green };//颜色数组
        Direction style;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                labs[i] = new Label();
                labs[i].BackColor = colors[i];
                labs[i].Size = new Size(30, 30);
                labs[i].Location = new Point(30 * i, 0);
                panel1.Controls.Add(labs[i]);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < N - 1; i++)
            {
                labs[i].Location = labs[i + 1].Location;
            }
            switch (style)
            {
                case Direction.right:
                    {
                        if (labs[N - 1].Left < panel1.Width - 30)
                        {
                            labs[N - 1].Left += 30;
                        }
                        else
                        {
                            style = Direction.down;
                        }
                        break;
                    }
                case Direction.down:
                    {
                        if (labs[N - 1].Top < panel1.Height - 30)
                        {
                            labs[N - 1].Top += 30;
                        }
                        else
                        {
                            style = Direction.left;
                        }
                        break;
                    }
                case Direction.left:
                    {
                        if (labs[N - 1].Left > 0)
                        {
                            labs[N - 1].Left -= 30;
                        }
                        else
                        {
                            style = Direction.up;
                        }
                        break;
                    }
                case Direction.up:
                    {
                        if (labs[N - 1].Top >0)
                        {
                            labs[N - 1].Top -= 30;
                        }
                        else
                        {
                            style = Direction.right;
                        }
                        break;
                    }
            }

        }
    }
}
