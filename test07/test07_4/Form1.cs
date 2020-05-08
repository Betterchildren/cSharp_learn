using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test07_4
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black);
        Point point1, point2;
        Graphics graphics = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = this.CreateGraphics();
            // Graphics 类提供用于将对象绘制到显示设备的方法。
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                point2 = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {   //鼠标移动就会调用这个方法
            if (e.Button == MouseButtons.Left)
            {
                point1 = point2;
                point2 = e.Location;
                graphics.DrawLine(pen, point1, point2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
        }
    }
}
