using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test06_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            BackColor = cd.Color;
            button1.BackColor = cd.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "颜色对话框";
        }
    }
}
