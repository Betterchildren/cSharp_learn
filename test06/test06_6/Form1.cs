using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test06_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.label1.Text = treeView1.SelectedNode.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "treeview";

            TreeNode trn11 = new TreeNode("n11");
            trn11.Name = "trn11";
            TreeNode trn12 = new TreeNode("n12");
            trn11.Name = "trn12";
            TreeNode trn13 = new TreeNode("n13");
            trn11.Name = "trn13";

            TreeNode trn1 = new TreeNode("n1");
            trn11.Name = "trn1";
            trn1.Nodes.Add(trn11);
            trn1.Nodes.Add(trn12);
            trn1.Nodes.Add(trn13);

            TreeNode trn2 = new TreeNode("n2");
            trn11.Name = "trn2";
            TreeNode trn3 = new TreeNode("n3");
            trn11.Name = "trn3";

            TreeNode tr = new TreeNode("根节点");
            tr.Name = "root";

            tr.Nodes.Add(trn1);
            tr.Nodes.Add(trn2);
            tr.Nodes.Add(trn3);
            treeView1.Nodes.Add(tr);
        }
    }
}
