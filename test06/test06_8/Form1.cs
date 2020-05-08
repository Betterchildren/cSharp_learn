using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test06_8
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "猜数字游戏";
            this.textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.ReadOnly = false;
            Random random = new Random();
            num = random.Next(0, 99);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                Boolean bl = false;
                int b = 0;
                bl = int.TryParse(textBox1.Text, out b);
                if (b > num)
                {
                    DialogResult d = MessageBox.Show("大啦!", "", MessageBoxButtons.OK);
                    this.textBox1.Text = null;
                }
                else if (b < num)
                {
                    DialogResult d = MessageBox.Show("小啦!", "", MessageBoxButtons.OK);
                    this.textBox1.Text = null;
                }
                else
                {
                    DialogResult d = MessageBox.Show("猜中啦!", "", MessageBoxButtons.OK);
                    this.textBox1.Text = null;
                    this.textBox1.ReadOnly = true;
                }
            }
        }
    }
}
