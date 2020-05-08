using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "动态添加图片";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("penguins.jpg");
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//使用 StretchImage 使图像拉伸或收缩，以便适合 PictureBox
            toolTip1.SetToolTip(pictureBox1, "北京风光");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }
    }
}
