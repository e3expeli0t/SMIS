using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SMIS.DataBase;

namespace SMIS
{
    public partial class TecherTime : Form
    {

        private String ID;
        
        //Every 45 minutes there is break
        private int max_hour = 19*60; // 19:00
        private int min_hour = 8*90; // 8:00


        public TecherTime(String teacherID)
        {
            InitializeComponent();
            this.ID = teacherID;

            for (int i = this.min_hour; i < this.max_hour; i += 45) {
                this.TimeList.Items.Add(i);
            }
        }

        private void TecherTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.UnavailableTime' table. You can move, or remove it, as needed.
            this.unavailableTimeTableAdapter.Fill(this.smisDataSet.UnavailableTime);

        }

        private void DoAdd_Click(object sender, EventArgs e)
        {
            SmisDataSet.TeachersRow row = ScheduleInit.GetTeacherRow(this.ID);

            this.smisDataSet.UnavailableTime.AddUnavailableTimeRow(row, this.Day.SelectedText, this.TimeList.SelectedText);
            this.unavailableTimeTableAdapter.Update(this.smisDataSet.UnavailableTime);
        }

    }
}
