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
    partial class FormLexical : Form
    {
        static public string origin;    //源程序
        public static Scanner new_scanner = new Scanner();
        string scanner_result = null;   //词法分析结果token
        string scanner_error = null;    //词法分析错误
        int flag = 0;   //是否需要重置标志

        public FormLexical()
        {
            InitializeComponent();
            if (Input.Text != null)
            {
                Input.Text = Properties.Settings.Default.lbSend;
                flag = 1;
            }
            if (LOutput.Text != null)
                LOutput.Text = Properties.Settings.Default.lbOut;
            if (LWrongput.Text != null)
                LWrongput.Text = Properties.Settings.Default.lbWrong;

        }

        private void Lbegin_MouseClick(object sender, MouseEventArgs e)  //词法分析开始
        {
            if (flag == 1)
                new_scanner.init();
            flag = 1;
            if (scanner_result != null)
            {
                new_scanner.init();
                scanner_result = null;
                scanner_error = null;
            }
            new_scanner.Scan();   //调用词法分析函数

            for (int i = 0; i < new_scanner.token_list.Count; i++)//将
            {
                //ss.Count();
                if (new_scanner.token_list[i].content != null)
                {
                    scanner_result = scanner_result + new_scanner.token_list[i].row.ToString() + ' ' +
                    new_scanner.token_list[i].tex.ToString() + ' ' +
                    new_scanner.token_list[i].content.ToString() + ' ' +
                    new_scanner.token_list[i].content_num.ToString() + "\r\n";
                }
                else
                {
                    scanner_result = scanner_result + new_scanner.token_list[i].row.ToString() + ' ' +
                    new_scanner.token_list[i].tex.ToString() + ' ' +
                    "null  " +
                    new_scanner.token_list[i].content_num.ToString() + "\r\n";
                }
            };
            LOutput.Text = scanner_result;  //输出token

            for (int i = 0; i < new_scanner.error_row.Count; i++)
            {
                scanner_error = scanner_error + new_scanner.error_row[i].ToString() + "\r\n";
            }
            LWrongput.Text = scanner_error;    //输出词法分析的错误
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            origin = Input.Text;
            new_scanner.read_from_source(origin);
        }

        private void FormLexical_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.lbSend = Input.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.lbOut = LOutput.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.lbWrong = LWrongput.Text;
            Properties.Settings.Default.Save();
        }
    }
}