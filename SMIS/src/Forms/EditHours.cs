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
    public partial class EditHours : Form
    {
        private String hours;

        public EditHours(String currentHoures)
        {
            InitializeComponent();
            this.hours = currentHoures;
            this.TimeList.Text = this.hours;

        }


        public String GetHours()
        {
            return this.hours;
        }

        private void AddHour_Click(object sender, EventArgs e)
        {

        }
    }
}
