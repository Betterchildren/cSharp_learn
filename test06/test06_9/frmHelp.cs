using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace test06_9
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("123.rtf", RichTextBoxStreamType.RichText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
