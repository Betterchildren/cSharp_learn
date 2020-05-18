using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace test08_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] bytes;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "*.jpg|*.jpg|*.gif|*.gif";
            of.ShowDialog();
            string fileNmae = of.FileName;
            label1.Text = fileNmae;
            if (string.IsNullOrEmpty(fileNmae)) return;//选择取消，则返回
            //图片路径
            pictureBox1.Image = Image.FromFile(fileNmae);
            //设置图片显示模式
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //使用文件流将图片保存至字节数组
            FileStream fs = new FileStream(fileNmae, FileMode.Open, FileAccess.Read);
            bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "*.jpg|*.jpg|*.gif|*.gif";
            sf.ShowDialog();
            
            string saveFileName = sf.FileName;
            if (string.IsNullOrEmpty(saveFileName)) return;//选择取消，则返回
            //使用文件流将保存在字节数组中数据复制到指定文件savefile
            FileStream fs = new FileStream(saveFileName, FileMode.Create, FileAccess.Write);
            fs.Write(bytes, 0, bytes.Length);
            MessageBox.Show("图片复制成功");
            fs.Dispose();
        }
    }
}
