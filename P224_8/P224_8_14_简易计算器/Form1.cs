using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P224_8_14_简易计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public double num1;//第一个数
       public double num2;//第二个数
       public int operation;//结果
        public void addNum(int num)
        {
            textBox1.Text = textBox1.Text + num.ToString();
        }
        private void btnEqu_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addNum(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addNum(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addNum(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addNum(4);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addNum(0);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addNum(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addNum(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addNum(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addNum(9);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = 1;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnMul_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }


    }
}
