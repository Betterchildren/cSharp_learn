using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test05_1
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
            //获取当前系统小时和分
            string s = DateTime.Now.Hour.ToString(); 
            string s1 = DateTime.Now.Minute.ToString(); 
            label1.Text = s+":"+s1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//设置边框为不可调节
            this.MaximizeBox = false;//取消最大化按键
            this.MinimizeBox = false;//取消最小化按键
        }
    }
}
