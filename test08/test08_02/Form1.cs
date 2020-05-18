using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace test08_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            FileInfo f = new FileInfo(textBox1.Text);
            if (f.Exists)
            {
                FileStream fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                byte[] bt = new byte[1024];
                while (fs.Read(bt, 0, bt.Length) > 0) //每次只从文件中读取部分字节数
                {
                    string txt = Encoding.UTF8.GetString(bt);  //解码转换成字符串
                    result.AppendLine(txt);
                }
                String str = result.ToString();
                richTextBox1.Text = str;
            }
            else
            {
                MessageBox.Show("请检查文件路径");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sr;
            if (File.Exists(textBox1.Text)) //如果文件存在,则创建File.AppendText对象
            {
                sr = File.AppendText(textBox1.Text);
            }
            else //如果文件不存在,则创建File.CreateText对象
            {
                sr = File.CreateText(textBox1.Text);
            }
            sr.WriteLine(richTextBox1.Text);
            sr.Close();
        }
    }
}
