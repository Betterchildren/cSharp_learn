using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace test08_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean flag = false;
        //可能要获取的路径名
        string localFilePath = "", fileNameExt = "", newFileName = "", FilePath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                //设置文件类型
                //书写规则例如：txt files(*.txt)|*.txt
                saveFileDialog.Filter = "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
                //设置默认文件名（可以不设置）
                saveFileDialog.FileName = "test";
                //主设置默认文件extension（可以不设置）
                saveFileDialog.DefaultExt = "txt";
                
                //保存对话框是否记忆上次打开的目录
                saveFileDialog.RestoreDirectory = true;

                // Show save file dialog box
                DialogResult result = saveFileDialog.ShowDialog();
                //点了保存按钮进入
                if (result == DialogResult.OK)
                {
                    //获得文件路径
                    localFilePath = saveFileDialog.FileName.ToString();

                    //获取文件名，不带路径
                    //fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);

                    //获取文件路径，不带文件名
                    //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                    //给文件名前加上时间
                    //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt;

                    //在文件名里加字符
                    //saveFileDialog.FileName.Insert(1,"dameng");
                    //为用户使用 SaveFileDialog 选定的文件名创建读/写文件流。
                    //System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();//输出文件

                    //fs可以用于其他要写入的操作
                }
            }
            flag = true;
            //Console.WriteLine(localFilePath);
            //File.WriteAllText("localFilePath", "");
            File.Delete(localFilePath);
            StreamWriter sr;
            if (File.Exists(localFilePath)) //如果文件存在,则创建File.AppendText对象
            {
                sr = File.AppendText(localFilePath);
            }
            else //如果文件不存在,则创建File.CreateText对象
            {
                sr = File.CreateText(localFilePath);
            }
            sr.WriteLine(richTextBox1.Text);
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
