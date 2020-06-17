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

        public static Subject Construct(String name, String id) {
            return new Subject(name, id);
        }


        public Subject(String name, String id) {
            this.name = name;
            this.id = id;
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
    }
}
