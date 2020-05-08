using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hudong4_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("a");
            listBox1.Items.Add("bc");
            listBox1.Items.Add("def");
            listBox1.Items.Add("wasd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Exited!");
            }
        }
    }
}
