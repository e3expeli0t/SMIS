using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    class Subject
    {
        private String name;
        private String id;

        private int total_time;
        private String class_id;

        public static Subject ConstructBasic(String name, String id)
        {
            return new Subject(name, id);
        }

        public static Subject Construct(String name, String id, String time, String class_id)
        {
            return new Subject(name, id, time, class_id);
        }


        public Subject(String name, String id)
        {
            this.name = name;
            this.id = id;
        }

        public Subject(String name, String id, String time, String class_id)
        {
            this.name = name;
            this.id = id;

            int t_time;
            if (!int.TryParse(time, out t_time)) {
                throw new InvalidCastException("total_time is not valid number!");
            }
            this.total_time = t_time;

            //todo: vlaidity checks
            this.class_id = class_id;
            
        }

        public String Name
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

        public String Id
        {
            get
            {
                return this.id;
            }
        }
        public String TotalTime
        {
            get
            {
                return this.total_time.ToString();
            }

            set
            {
                int t_time;
                if (!int.TryParse(value, out t_time))
                {
                    throw new InvalidCastException("total_time is not valid number!");
                }
                this.total_time = t_time;
            }
        }
        public String ClassId
        {
            get
            {
                return this.class_id;
            }

            set
            {
                this.class_id = value;
            }
        }

    }
}
