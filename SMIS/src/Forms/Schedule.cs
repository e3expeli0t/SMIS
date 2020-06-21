using SMIS.Scheduler;
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
    public partial class Schedule : Form
    {
        private Scheduler.Scheduler scheduler;
        private int hours_by_day = 11;
        public Schedule()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            this.scheduler = new Scheduler.Scheduler();
            Cursor.Current = Cursors.Default;
        }

        private void DoSchedule_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            ScheduledForm form =  this.scheduler.Schedule(this.hours_by_day);
            this.FillRows(form);

            Cursor.Current = Cursors.Default;
        }

        private void FillRows(ScheduledForm form)
        {
            Days[] Week = DefaultValues.Week;
            foreach (Days day in Week)
            {
                for (int i = 0; i < this.hours_by_day; i++)
                {
                    Scheduler.Group current = form.GetDay(day).GetByHour(i);
                    this.ScheduleView.Rows.Add(i, current.GroupClass.Name, current.GroupTeacher.FullName, current.GroupSubject.Name);
                }
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
