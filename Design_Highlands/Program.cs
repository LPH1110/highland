using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new Home());
            //Application.Run(new QLNV());
            //Application.Run(new QLMenu());
            //Application.Run(new QLTV());
            //Application.Run(new AddNewStaff());
            Application.Run(new AddNewMember());



        }
    }
}
