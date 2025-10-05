using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using FontAwesome.Sharp;
using WFD.Forms;

namespace WFD
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;  
        private Panel leftBorderBtn;
        private Form currentChildFrom;
        public FormMain()
        {
            InitializeComponent(); 
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //窗口更灵活,能够扩大到电脑屏幕大小
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBcolo   //自定义设置一些颜色
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221  );
            public static Color color5 = Color.FromArgb(249,88,155 );
            public static Color color6 = Color.FromArgb(24,161,251 );
        }
        //methods
        private void  ActivateButton(object senderBtn, Color color)  //新增加组件ICon设置
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //IconChile 与title图像一致
                iconChild.IconChar = currentBtn.IconChar;
                iconChild.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void OpenChildFrom(Form childForm)//标签页面
        {
            if(currentChildFrom != null)
            {
                //只打开一个页面
                currentChildFrom.Close();
            }
            currentChildFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm; //获取对象
            childForm.BringToFront();//将控件带到最前面
            childForm.Show();//向用户显示控件
            labelTitleChildFrom.Text = childForm.Text;
        }
        //侧面标签设置
        private void iconButton1_Click(object sender, EventArgs e)//词法分析
        {
            ActivateButton(sender, RGBcolo.color1);
            OpenChildFrom(new FormLexical());
        }

        private void iconButton2_Click(object sender, EventArgs e)//语法分析
        {
            ActivateButton(sender, RGBcolo.color2);
            OpenChildFrom(new Formgrammatical());
        }

        private void iconButton3_Click(object sender, EventArgs e)//语义分析
        {
            ActivateButton(sender, RGBcolo.color3);
            OpenChildFrom(new Formsemantic());
        }

        private void btnHome_Click(object sender, EventArgs e)//Home键
        {
            if (currentChildFrom != null)
                currentChildFrom.Close();
            Reset();
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolo.color4);
            System.Diagnostics.Process.Start("https://docs.microsoft.com/zh-cn/visualstudio/windows/?f1url=%3FappId%3DDev16IDEF1%26l%3Dzh-CN%26k%3Dk(MSDNSTART)%26rd%3Dtrue&view=vs-2022");
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolo.color4);
            System.Diagnostics.Process.Start("https://visualstudio.microsoft.com/zh-hans/vs/support/");
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconChild.IconChar = IconChar.Home;
            iconChild.IconColor = Color.MidnightBlue;
            labelTitleChildFrom.Text = "Home";
        }
        //Drag From

        //窗口可以拖动
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btExit_Click_1(object sender, EventArgs e)//关闭界面
        {
            Application.Exit();
        }

        private void PBMinMax_Click(object sender, EventArgs e)//还原界面
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pBMin_Click(object sender, EventArgs e)//最小化界面
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                DirectoryInfo theFolder = new DirectoryInfo(foldPath);
                

                Scanner scanner = new Scanner();
                scanner.Scan();
                scanner.ChainToFile(foldPath);
                /*FileInfo[] dirInfo = theFolder.GetFiles();
                //遍历文件夹                
                foreach (FileInfo file in dirInfo)
                {
                    MessageBox.Show(file.ToString());
                }*/
            }
        }
    }
}
