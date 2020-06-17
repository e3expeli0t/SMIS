using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SMIS.Scheduler;
using SMIS.DataBase;

namespace SMIS
{
    public partial class ViewUTime : Form
    {
        Dictionary<String, String> id_map = new Dictionary<String, String>();
        public ViewUTime()
        {
            InitializeComponent();
            Teacher[] teachers = ScheduleInit.GetTeachers();

            foreach (Teacher t in teachers)
            {
                this.id_map.Add(t.FirstName + " " + t.LastName, t.Id);
                this.TeacherSelector.Items.Add(t.FirstName + " " + t.LastName);
            }
        }

        private void ViewUTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.UnavailableTime' table. You can move, or remove it, as needed.
            this.unavailableTimeTableAdapter.Fill(this.smisDataSet.UnavailableTime);

        }

        private void search()
        {
            String name = this.TeacherSelector.Text;
            if (name == "All")
            {
                this.unavailableTimeBindingSource.RemoveFilter();
            }
            else {
                this.unavailableTimeBindingSource.Filter = String.Format("TeacherID='{}'", this.id_map[name]);
            }
        }

        private void DoReset_Click(object sender, EventArgs e)
        {
            this.unavailableTimeBindingSource.RemoveFilter();
        }

        private void TeacherSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.search();
        }
    }
}
