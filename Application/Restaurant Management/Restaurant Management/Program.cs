﻿using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using Restaurant_Management.bul.frm;

namespace Restaurant_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            Application.Run(new frmLogin());            
        }
    }
}