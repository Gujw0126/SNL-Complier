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
    public partial class Formsemantic : Form
    {
        Node tree = Formgrammatical.tree;

        public Formsemantic()
        {
            InitializeComponent();
            if (SOutPut.Text != null)
                SOutPut.Text = Properties.Settings.Default.sbOut;
            if (Swrongout.Text != null)
                Swrongout.Text = Properties.Settings.Default.sbWrong;
        }
        private void Sbegin_Click(object sender, EventArgs e)
        {
            Semantic new_semantic = new Semantic(tree);
            new_semantic.Analyze(tree);     //执行语义分析
            SOutPut.Clear();
            for(int i=0;i<new_semantic.STables.Count;i++)
            {
                for (int j = 0; j < new_semantic.STables[i].Count; j++)
                {
                    SOutPut.Text += new_semantic.STables[i][j] + ' ';
                }
                SOutPut.Text += "\r\n";
            }
            Swrongout.Clear();
            foreach (string str in new_semantic.error)
            {
                Swrongout.Text += str;
                Swrongout.Text += "\r\n";
            }
            Now_L.Text = "√" + "分析完成";

        }
        private void Formsemantic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.sbOut = SOutPut.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.sbWrong = Swrongout.Text;
            Properties.Settings.Default.Save();
        }
    }
}
