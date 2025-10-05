using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFD
{
    public partial class FlashScreen : Form
    {
        public FlashScreen()
        {
            InitializeComponent();
        }

        private void timerProgressbar_Tick(object sender, EventArgs e)
        {
            panelProcessbar.Width += 40;//设置进度条
            if(panelProcessbar.Width>=1898)
            {
                timerProgressbar.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void panelProcessbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
