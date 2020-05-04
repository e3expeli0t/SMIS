using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMISInternal
{
    class Errors
    {
        public static void DisplayMinor(String info)
        {
            MessageBox.Show(info, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DisplayMajor(String info)
        {
            MessageBox.Show(info, "Fatal Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void HandleException(Exception e)
        {
            Console.Beep(); // tmp only for developmant 
            Console.WriteLine("Execption handled: ", e.Data);
        }
    }
}
