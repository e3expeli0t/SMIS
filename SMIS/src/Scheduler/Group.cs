using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    class Group
    {
        private Teacher teacher;
        private Class group_class;
        private Subject subject;

        public static  Group Construct(Teacher teacher, Class c, Subject s)
        {
            return new Group(teacher, c, s);
        }

        public Group(Teacher teacher, Class c, Subject s)
        {
            this.group_class = c;
            this.subject = s;
            this.teacher = teacher;
        }

        public Teacher GroupTeacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }
        public Class GroupClass
        {
            get
            {
                return this.group_class;
            }
            set
            {
                this.group_class = value;
            }
        }
        public Subject GroupSubject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }
    }
}
