using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace test06_3
{
    public partial class Form1 : Form
    {
        private Stream myStream;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // 获取或设置文件对话框显示的初始目录。
            ofd.InitialDirectory = "d:\\";
            //获取或设置当前文件名筛选器字符串，该字符串决定对话框的“另存为文件类型”或“文件类型”框中出现的选择内容。
            ofd.Filter = "(*.txt)|*.txt|(*.*)|*>**";
            ofd.FilterIndex = 1;
            //获取或设置一个值，该值指示该对话框在关闭前是否将目录还原为之前选定的目录。
            ofd.RestoreDirectory = true;
            // ofd.ShowDialog(); 打开 打开文件窗口
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        //输入流
                        StreamReader st = new StreamReader(ofd.FileName, Encoding.GetEncoding("UTF-8"));
                        string str = st.ReadLine();
                        while (str != null)
                        {
                            richTextBox1.AppendText(str);
                            richTextBox1.AppendText("\n");
                            str = st.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件出错：" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "D:\\.net\\实验\\实验6 windows(2)";
            sfd.Filter = "(*.txt)|*.txt|(*.*)|*>**";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //mode用于确定文件的打开或创建方式的枚举值之一。
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text);
                sw.Close();
                fs.Close();
            }
        }
    }
}
