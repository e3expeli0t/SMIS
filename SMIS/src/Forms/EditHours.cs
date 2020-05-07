using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMISInternal;

namespace SMIS
{
    public partial class EditHours : Form
    {
        private String hours;
        private bool good = true;

        public EditHours(String currentHours)
        {
            InitializeComponent();
            this.hours = currentHours;

            if (!(this.hours == ""))
            {
                List<String> extractTime = Time.extractTime(this.hours);

                if (extractTime == null || !extractTime.Any()) {
                    Errors.DisplayMajor("Couldn't parse time. please try reload the application\n"
                    + "For any help contact the Adminstartor\n\n\nFIXME: error recovry");
                    this.good = false;
                    this.hours = null;
                    return;
                }

                foreach (String h in extractTime)
                {
                    this.TimeList.Items.Add(h);
                }
            }
        }


        public bool Good()
        {
           return this.good;
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
