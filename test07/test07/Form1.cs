using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace test07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,Color.White, Color.Green, LinearGradientMode.Vertical);
            g.FillRectangle(brush, this.ClientRectangle);
            // this.ClientRectangle 获取表示控件的工作区的矩形
            g.Dispose();
        }
    }
}
