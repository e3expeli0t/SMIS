using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    public enum Days
    {
        Sunday, 
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

    class Day
    {
        //Hour mark map. True = occupy false = occupy. if the map is unavl this
        // means that the marked hour is unaval if it is aval this means that the marked hour is
        // aval 
        private Dictionary<int, bool> free_map = new Dictionary<int, bool>();
        private Days name;
        private bool full;
        private int max_cap;
        private int current;

        public Day(Days d, int max_hour) {
            this.name = d;
            this.max_cap = max_hour;
            this.current = 0;

            for (int i = 0; i <= max_hour; i++)
            {
                this.free_map[i] = true;
            }
        }

        public bool IsHourFree(int hour_no)
        {
            return this.free_map[hour_no];
        }

        public void UnMark(int hour_no) {
            this.free_map[hour_no] = false;
            this.RemTick();
        }

        public void Mark(int hour_no)
        {
            if (full)
            {
                return;
            }
            this.free_map[hour_no] = true;
            this.AddTick();
        }

        public bool Full()
        {
            return this.full;
        }

        private void AddTick() {
            ++this.current;
            if (this.max_cap-this.current <= 0)
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
