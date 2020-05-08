using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test06_9
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            openForm2();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "主窗体";
            this.toolStripStatusLabel1.Text = "u1";
            toolStripButton_2.ToolTipText = "打开窗体1";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            openForm1();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openForm1();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openForm2();
        }

        public void openForm1()
        {
            frm1 form1 = new frm1();
            form1.TopLevel = false;//设置该窗体不为顶级窗体。
            this.IsMdiContainer = true;
            form1.MdiParent = this;
            //form1.showdialog();//错误，因为TopLevel属性为false.
            form1.Show(); //正常
        }
        public void openForm2()
        {
            frm2 form2 = new frm2();
            form2.TopLevel = false;//设置该窗体不为顶级窗体。
            form2.MdiParent = this;
            //form1.showdialog();//错误，因为TopLevel属性为false.
            form2.Show(); //正常
        }

        public void openHelp()
        {
            frmHelp fh = new frmHelp();
            fh.TopLevel = false;//设置该窗体不为顶级窗体。
            fh.MdiParent = this;
            fh.Show();
        }

        public void closeForm()
        {
            foreach (Form myForm in this.MdiChildren)// 遍历所有子窗体{
            {
                myForm.Close(); //关闭子窗体
            }
        }

        public void quitDialog()
        {
            DialogResult dr = MessageBox.Show("确认退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            quitDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            quitDialog();
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm();
            openHelp();
        }
    }
}
