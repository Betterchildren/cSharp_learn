using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace test08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 这道题没弄明白题目要求
            // 把基本的功能写进去了
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*创建文件夹*/
            //Directory类
            Directory.CreateDirectory("D:\\TTT");
            //DirectionInfo类
            DirectoryInfo di = new DirectoryInfo("D:\\AAA");
            di.Create();
            /*移动文件夹*/
            /*
            //Directory类
            Directory.Move("D:\\TTT", "D:\\AAA");
            //DirectoryInfo类
            DirectoryInfo di1 = new DirectoryInfo("D:\\TTT");
            di1.MoveTo("D:\\AAA");
            //删除文件夹
            //Directory类
            Directory.Delete("D:\\TTT");
            //DirectoryInfo类
            DirectoryInfo di=new DirectoryInfo("D:\\TTT");
            di.Delete();
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Directory类
            Directory.CreateDirectory("D:\\TTT");
            //DirectionInfo类
            DirectoryInfo di = new DirectoryInfo("D:\\TTT");
            di.Create();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //判断文件是否存在
            File.Exists("D:\\abc.txt");
            FileInfo f = new FileInfo("D:\\abc.txt");
            if (f.Exists) { }
            //创建文件，删除文件（Create换成Delete）
            File.Create("D:\\test.txt");
            /*FileInfo f1 = new FileInfo("C:\\abc1.txt");
            f1.Create();
            //复制文件
            File.Copy("C:\\abc.txt", "D:\\abc.txt");
            FileInfo f2 = new FileInfo("C:\\abc1.txt");
            f2.CopyTo("D:\\abc1.txt");
            //移动文件
            File.Move("C:\\abc.txt", "D:\\Newabc.txt");
            FileInfo f3 = new FileInfo("C:\\abc.txt");
            f3.MoveTo("D:\\Newabc.txt");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断文件是否存在
            File.Exists("D:\\abc.txt");
            FileInfo f = new FileInfo("D:\\abc.txt");
            if (f.Exists) { }
            //创建文件，删除文件（Create换成Delete）
            File.Create("D:\\test.txt");
            /*FileInfo f1 = new FileInfo("C:\\abc1.txt");
            f1.Create();
            //复制文件
            File.Copy("C:\\abc.txt", "D:\\abc.txt");
            FileInfo f2 = new FileInfo("C:\\abc1.txt");
            f2.CopyTo("D:\\abc1.txt");
            //移动文件
            File.Move("C:\\abc.txt", "D:\\Newabc.txt");
            FileInfo f3 = new FileInfo("C:\\abc.txt");
            f3.MoveTo("D:\\Newabc.txt");*/
        }
    }
}
