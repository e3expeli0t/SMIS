using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    class GroupDay
    {
        private Dictionary<int, Group> assignd_map = new Dictionary<int, Group>();
        private Days name;

        private bool full;
        private int max_cap;
        private int current;

        public GroupDay(Days d, int max_hour)
        {
            this.name = d;
            this.max_cap = max_hour;
            this.current = 0;

            for(int i = 0; i <= max_hour; i++)
            {
                this.assignd_map.Add(i, null);
            } 
        }

        public Group GetByHour(int hour)
        {
            return this.assignd_map[hour];
        }

        public bool IsHourFree(int hour_no)
        {
            return this.assignd_map[hour_no] == null;
        }

        public void UnMark(int hour_no)
        {
            this.assignd_map[hour_no] = null;
            this.RemTick();
        }

        public void Mark(int hour_no, Group g)
        {
            if (full)
            {
                return;
            }
            this.assignd_map[hour_no] = g;
            this.AddTick();
        }

        public bool Full()
        {
            return this.full;
        }

        private void AddTick()
        {
            ++this.current;
            if (this.max_cap - this.current <= 0)
            {
                this.full = true;
            }
        }

        private void RemTick()
        {
            if (this.current == 0)
            {
                return;
            }
            --this.current;

            if (this.full)
            {
                this.full = false;
            }
        }

        public Days Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        

    }
}
