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
            this.DataBindings.Clear();
            Cursor.Current = Cursors.WaitCursor;


            ScheduledForm form = this.scheduler.Schedule(this.hours_by_day);
            this.FillRows(form);

            Cursor.Current = Cursors.Default;
        }

        private void FillRows(ScheduledForm form)
        {
            Days[] Week = DefaultValues.Week;
            Scheduler.Group current;

            List<String> rows = new List<String>();
            
            for (int i = 0; i < this.hours_by_day; i++)
            {
                foreach (Days day in Week)
                {
                    current = form.GetDay(day).GetByHour(i);

                    if (current == null)
                    {
                        continue;
                    }

                    this.AddRow(i, day, current);
                }
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void AddRow(int time, Days day, Group g) {
            if (this.ScheduleView.CurrentRow == null || time >= this.ScheduleView.CurrentRow.Index)
            {
                this.ScheduleView.Rows.Add();
            }
            this.ScheduleView.Rows[time].Cells["Hour"].Value = time.ToString();
            this.ScheduleView.Rows[time].Cells[day.ToString()].Value = g.ToString();

        }

        private String generate(Scheduler.Group g, int time, Days day)
        {
            return g.ToString();
        }
    }
}
