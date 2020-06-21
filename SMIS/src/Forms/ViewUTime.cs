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
            int dup_count = 0;

            foreach (Teacher t in teachers)
            {
                String name = t.FirstName + " " + t.LastName;
                if (id_map.ContainsKey(t.FirstName + " " + t.LastName)) {
                    name += "_" + dup_count;
                    dup_count++;

                }
                this.id_map.Add(name, t.Id);
                this.TeacherSelector.Items.Add(name);
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
                this.unavailableTimeBindingSource.Filter = String.Format("TeacherID='{0}'", this.id_map[name]);
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
