using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test06_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void 北京ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "故宫,天坛";
        }

        private void 南京ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "中统府,夫子庙";
        }

        private void 青岛ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "栈桥,崂山";
        }

        private void 西安ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "华山,大雁塔,华清池";
        }

        private void 上海ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "外滩,田子坊,东方明,珠金融中心";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "快捷菜单的使用";
        }
    }
}
