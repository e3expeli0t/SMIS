using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SMISSecurity;
namespace SMIS
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
            
            SMISSecurity.Login lgn = new SMISSecurity.Login();
            Login lform = new Login();
            //Application.Run(lform);


            if (lform.Success()) {
                Application.Run(new MainMenu());
            } else {
                //todo: Error handling
            }
        }
    }
}
