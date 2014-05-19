using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;

//using WCFServiceWebRole1;

namespace coder
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
           
            //CloudStorageAccount.DevelopmentStorageAccount.

            
           

            Application.Run(new Shell());
           
        }
    }
}
