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
        private int CURRENT = 0;

        public EditHours(String currentHours)
        {
            InitializeComponent();
            this.hours = currentHours;
            this.CURRENT = this.TimeList.SelectedIndex;
            this.TimePicker.ResetText();

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
                    if (h != "")
                    {
                        this.TimeList.Items.Add(h);
                    }
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
            this.TimeList.Items.Add(this.TimePicker.Text);
            hours = TimeList.Items.ToString();
        }

        private void DoRemove_Click(object sender, EventArgs e)
        {
            this.TimeList.Items.RemoveAt(this.CURRENT);
            this.TimeList.Refresh();
        }

        private void TimeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CURRENT = this.TimeList.SelectedIndex;
        }
    }
}
