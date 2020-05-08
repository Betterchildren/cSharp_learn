using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test07_3
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
            Image image = Image.FromFile(Application.StartupPath + @"\p1.jpg");
            TextureBrush brush = new TextureBrush(image);
            Font font = new Font("黑体", 60, FontStyle.Underline ^ FontStyle.Bold);
            g.DrawString("烟台大学", font, brush, new Point(10, 10));
            g.Dispose();
        }
    }
}
