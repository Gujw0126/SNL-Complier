using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFD
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FlashScreen());
            FlashScreen splashScreen = new FlashScreen();
            if (splashScreen.ShowDialog() == DialogResult.OK)
                Application.Run(new FormMain());
            //else
            //Application.Exit();
        }
    }
}
