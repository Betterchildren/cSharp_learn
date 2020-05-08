using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test05_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("宋体", 48, FontStyle.Regular);
            label1.AutoSize = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, checkBox1.Checked ? label1.Font.Style | FontStyle.Italic : label1.Font.Style ^ (FontStyle.Italic));
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, checkBox2.Checked ? label1.Font.Style | FontStyle.Underline : label1.Font.Style ^ (FontStyle.Underline));
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, checkBox3.Checked ? label1.Font.Style | FontStyle.Bold : label1.Font.Style ^ (FontStyle.Bold));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("黑体", label1.Font.Size, label1.Font.Style);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("楷体", label1.Font.Size, label1.Font.Style);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, hScrollBar1.Value);
        }
    }
}
