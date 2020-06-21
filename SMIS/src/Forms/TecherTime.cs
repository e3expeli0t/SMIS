using System;
using System.Windows.Forms;

using SMIS.DataBase;
using SMISInternal;

namespace SMIS
{
    public partial class TecherTime : Form
    {
        private int max_hour = 11;
        private String ID;

        public TecherTime(String teacherID)
        {
            InitializeComponent();
            this.ID = teacherID;

            for (int i = 0; i < this.max_hour; i++) {
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
            this.smisDataSet.AcceptChanges();

            SmisDataSet.TeachersRow row = ScheduleInit.GetTeacherRow(this.ID);

            this.smisDataSet.UnavailableTime.AddUnavailableTimeRow(row, this.Day.Text, this.TimeList.Text);
            this.unavailableTimeTableAdapter.Update(this.smisDataSet.UnavailableTime);
        }

        private void DoRemove_Click(object sender, EventArgs e)
        {
            if (this.TTimeView.CurrentRow.Index > this.TTimeView.RowCount) {
                Errors.DisplayMinor("There is no data to remove");
                return;
            }
            this.smisDataSet.UnavailableTime[this.TTimeView.CurrentRow.Index].Delete();
            this.unavailableTimeTableAdapter.Update(this.smisDataSet.UnavailableTime);
        }
    }
}
