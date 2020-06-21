using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    class ScheduledForm
    {
        private bool full = false;
        private int total_avl = 0;

        private Dictionary<Days, GroupDay> assign_map = new Dictionary<Days, GroupDay>();

        public ScheduledForm(Days[] week, int max_day_time)
        {
            foreach(Days d in week)
            {
                this.assign_map.Add(d, new GroupDay(d, max_day_time));
                this.total_avl += max_day_time;
            }
        }

        public GroupDay GetDay(Days d)
        {
            return this.assign_map[d];
        }

        public void Add(Days d, int hour, Group g)
        {
            if (!this.IsFull()) {
                this.assign_map[d].Mark(hour, g);
                this.Tick();
            }
        }
        public bool IsFull()
        {
            return this.full;
        }

        private void Tick()
        {
            this.total_avl--;
            if (total_avl == 0)
            {
                this.full = true;
            }
        }
    }
}
