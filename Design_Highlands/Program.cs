﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Design_Highlands
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Home());
            //Application.Run(new QLNV());
            //Application.Run(new QLMenu());
            //Application.Run(new QLTV());
            //Application.Run(new AddNewStaff());
            //Application.Run(new AddNewMember());



        }
    }
}
