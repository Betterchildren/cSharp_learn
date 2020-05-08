using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test05_6
{
    public partial class Form1 : Form
    {

        string str; //接收由radioButton决定的文本
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            str = textBox1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            str = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = str;
        }
    }
}
