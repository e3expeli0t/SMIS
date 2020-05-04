using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMIS
{
    public partial class Init : Form
    {
        public Init()
        {
        }

        private void Init_Load(object sender, EventArgs e)
        {
            if (true) {
                
                MainMenu main = new MainMenu();
                main.Show();
            } 
        }
    }
}
