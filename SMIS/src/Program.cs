using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SMISSecurity;
using SMISInternal;


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
                try
                {
                    Application.Run(new MainMenu());
                }
                catch (Exception e)
                {
                    
                    Errors.DisplayMajor("An error acoured. Reseting...\nError: " + e.Message);
                }
                finally
                {
                    Application.Run(new MainMenu());
                }
            } else {
                //todo: Error handling
            }
        }
    }
}
