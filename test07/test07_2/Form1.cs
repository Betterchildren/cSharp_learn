using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test07_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel1.Refresh();
            //刚开始运行正常,但是时间长就会像卡了一样,标签跟不上圆域
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);//笔的颜色,粗细
            int r = 100;//半径
            Random rd = new Random();
            int X = rd.Next(0, this.panel1.Width - 2 * r);
            int Y = rd.Next(0, this.panel1.Height - 2 * r);//圆能活动的范围
            g.DrawEllipse(pen, X, Y, 2 * r, 2 * r);//画圆,矩形左上角坐标决定矩形位置
            SolidBrush sb = new SolidBrush(Color.Blue);
            g.FillEllipse(sb, X, Y, 2 * r, 2 * r);
            label1.Location = new Point(X + r, Y + r);
            label1.Text = "X=" + (X + r) + ",Y=" + (Y + r);
        }
    }
}
