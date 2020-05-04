using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMIS.DBControl;

namespace SMIS
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {

        }

        public static  bool exist(string elem)
        {
            //throw new NotImplementedException();
            return true;
        }

        public static object lookup(string elem)
        {
            throw new NotImplementedException();
        }
    }
}
