﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_02
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.ThreadException += new ThreadExceptionEventHandler(OnThreadException);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }

        static void OnThreadException(object sender, ThreadExceptionEventArgs t)
        {

            MessageBox.Show(t.Exception.ToString(), "OnThreadException");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString(), "CurrentDomain_UnhandledException");
        }
    }
}
