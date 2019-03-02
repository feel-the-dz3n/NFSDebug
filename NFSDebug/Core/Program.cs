using NFSDebug.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace NFSDebug
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new MainWindow().ShowDialog();
        }
    }
}
