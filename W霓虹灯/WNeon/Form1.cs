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
    public partial class Form1 : Form
    {
        Color[] colors = new Color[5] { Color.Cyan, Color.Red, Color.Pink, Color.Yellow, Color.Green };//颜色数组
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Label lab1 = new Label();
                lab1.BackColor = colors[i];
                lab1.Size = new Size(30, 30);
                lab1.Location = new Point(30*i, 0);
                panel1.Controls.Add(lab1);
            }
        }
    }
}
