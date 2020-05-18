using System;
using System.Windows.Forms;
using System.Xml;

namespace test08_05
{
    class Class1
    {

        public void Open(TreeView tv, string xmlFileName)
        {
            try
            {
                tv.Nodes.Clear();
                //引入XML文件
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlFileName);
                //获取根元素
                XmlNode root = xml.DocumentElement;
                //赋值给tn
                TreeNode tn = new TreeNode();
                tn.Text = root.Name;
                //添加到treeView中
                tv.Nodes.Add(tn);
                //填充tn元素
                GetTreeNode(root, tn);

                tv.Nodes[0].Expand();
                tv.LabelEdit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void GetTreeNode(XmlNode xn, TreeNode tn)
        {
            //深度搜索，填充tn元素
            foreach (XmlNode item in xn.ChildNodes)
            {
                TreeNode temp = null;
                if (item.HasChildNodes)
                {
                    temp = new TreeNode(item.Name);

                }
                else
                {
                    temp = new TreeNode(item.InnerText);
                }
                tn.Nodes.Add(temp);
                GetTreeNode(item, temp);
            }
        }

    }
}
