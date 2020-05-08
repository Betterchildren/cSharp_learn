using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test06_9
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "登录窗体";
            this.ControlBox = false;
            //this.MinimizeBox = false;
            //this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="u1" && textBox2.Text == "123")
            {
                this.Hide();
                frmMain frMain = new frmMain();   //frmMain为窗口名，把要跳转的新窗口实例化
                frMain.ShowDialog();   //打开新窗口
                this.Dispose();
                this.Close();  //关闭当前窗口   
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if (textBox1.Text == "u1" )
            {
                MessageBox.Show("密码错误", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("用户名错误", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
