using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFD.Forms
{
    public partial class Formgrammatical : Form
    {
        static Scanner new_scanner = FormLexical.new_scanner;
        static public Node tree = new Node();

        public Formgrammatical()
        {
            InitializeComponent();
            if (RecursionOutput.Text != null)
                RecursionOutput.Text = Properties.Settings.Default.tbSend;
            if (textBox1.Text != null)
                textBox1.Text = Properties.Settings.Default.gwrong;
        }

        private void ToolDGXJ_Click_1(object sender, EventArgs e)   //递归下降法
        {
            Grammar new_grammar = new Grammar(new_scanner);
            Tip.Text ="分析方法："+ ToolDGXJ.Text;//让提示语变化
            RecursionOutput.Clear();
            new_grammar.grammar();
            foreach (string ele in new_grammar.tree_str)
            {
                RecursionOutput.Text += ele;
            }
            tree = new_grammar.root;

            /*--------------树状体输出------------------------*/
            this.treeView.Nodes.Clear();//清空节点
            treeView.LabelEdit = false;//不可编辑

            Node tt = tree;
            TreeNode tn1 = treeView.Nodes.Add(tt.name);//首先将根节点存入
            TreeAdd(tt, tn1);
            /*--------------错误输出------------------------*/
            textBox1.Clear();
            foreach (string info in new_grammar.error_inf)
            {
                textBox1.Text += info;
                textBox1.Text += "\r\n";
            }

        }

        private void ToolLL1_Click_1(object sender, EventArgs e)    //LL1
        {
            Tip.Text = "分析方法：" + ToolLL1.Text;
            LL1 new_LL1 = new LL1();
            RecursionOutput.Clear();
            new_LL1.LL1_main(new_scanner);
            foreach (string ele in new_LL1.tree_str)
            {
                RecursionOutput.Text += ele;
            }
            tree = new_LL1.TREE;

            /*--------------树状体输出------------------------*/
            this.treeView.Nodes.Clear();//清空节点
            treeView.LabelEdit = false;//不可编辑

            Node tt = tree;
            TreeNode tn1 = treeView.Nodes.Add(tt.name);//首先将根节点存入
            TreeAdd(tt, tn1);
            /*--------------错误输出------------------------*/
            textBox1.Clear();
            foreach (string info in new_LL1.error)
            {
                textBox1.Text += info;
                textBox1.Text += "\r\n";
            }

        }


        private void TreeAdd(Node root, TreeNode tn)  //递归产生TreeView树
        {
            for (int i = 0; i < root.son.Count; i++)
            {
                TreeNode tx = new TreeNode(root.son[i].name);
                tn.Nodes.Add(tx);
                if (root.son[i].son != null)
                    TreeAdd(root.son[i], tx);
            }
        }

        private void Formgrammatical_FormClosing(object sender, FormClosingEventArgs e)//关闭页面，保留内容
        {
            Properties.Settings.Default.tbSend = RecursionOutput.Text;
            Properties.Settings.Default.Save();

            

            Properties.Settings.Default.gwrong = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
