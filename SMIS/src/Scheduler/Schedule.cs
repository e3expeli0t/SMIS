using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SMIS.DataBase;
using SMISInternal;

namespace SMIS.Scheduler
{
    class Scheduler
    {
        private Teacher[] teachers;
        private Group[] groups;
        private ScheduleInit loader;
        private Days[] Week;

        public Scheduler()
        {
            this.Week = new Days[] { Days.Sunday, Days.Monday, Days.Tuesday, Days.Wednesday, Days.Thursday, Days.Friday };
            this.loader = new ScheduleInit();

            try
            {
                this.groups = this.loader.LoadGroups();
                this.teachers = this.loader.LoadTeachers();
                this.teachers = this.loader.LoadTime(this.teachers);
            }
            catch (Exception e)
            {
                Errors.DisplayMajor(
                    String.Format(
                        "An error has occourd during schedling pre-proccessing\n{0}\n\n", e.ToString()
                    )
                    );
            }
        }

        public ScheduledForm Schedule(int hours_per_day)
        {
            ScheduledForm scheduled = new ScheduledForm(this.Week, hours_per_day);
            int current_group = 0;
            int day_hour_counter = 0;
            int groups_count = this.groups.Count();

            foreach (Days day in this.Week)
            {
                day_hour_counter = 0;
                if (scheduled.IsFull())
                {
                    break;
                }

                if (current_group > groups_count)
                {
                    break;
                }

                while(current_group < groups_count &&  !scheduled.GetDay(day).Full())
                {
                    if (this.groups[current_group] == null)
                    {
                        break;
                    }


                    if (!this.groups[current_group].GroupTeacher.Time.GetUnAval()[day].IsHourFree(day_hour_counter))
                    {
                        day_hour_counter++;
                        continue;
                    }

                    scheduled.Add(day, day_hour_counter, this.groups[current_group]);
                    day_hour_counter++;
                    current_group++;
                }
            }

            return scheduled;
        }


    }
}
