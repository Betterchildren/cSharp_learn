using System;
using System.Windows.Forms;

namespace test08_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "递归挂树";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 xml = new Class1();
            xml.Open(this.treeView1, "XMLFile2.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
