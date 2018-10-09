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

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("雨心Dream \n 项目地址：https://github.com/izzp/Study_C-SHARP");
        }

        private void textBoxRedLight_TextChanged(object sender, EventArgs e)
        {
    
        }




    }
}
