using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    class AvailableTime
    {

        private Dictionary<Days, Day> aval_map = new Dictionary<Days, Day>();
        private Dictionary<Days, Day> un_val_map = new Dictionary<Days, Day>();
        
        public AvailableTime(Days[] week)
        {
            foreach (Days day in week)
            {
                this.aval_map[day] = new Day(day, DefaultValues.max_hours);
                this.un_val_map[day] = new Day(day, DefaultValues.max_hours);
            }
        }

        public static Days MakeDays(String val)
        {
            return (Days)Enum.Parse(typeof(Days), val, true);
        }

        public Dictionary<Days, Day> GetAval() {
            return this.aval_map;
        }
        public Dictionary<Days, Day> GetUnAval()
        {
            return this.un_val_map;
        }
        //Full?
        public void MakeUnAvl(Days d, int hour) {
            this.aval_map[d].UnMark(hour);
            this.un_val_map[d].Mark(hour);
        }

        public void MakeAvl(Days d, int hour)
        {
            this.aval_map[d].Mark(hour);
            this.un_val_map[d].UnMark(hour);
        }
    }
}
