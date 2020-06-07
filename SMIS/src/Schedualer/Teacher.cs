using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Schedualer
{
    class Teacher
    {
        private String firstName;
        private String lastName;
        private DateTime[] preferdTime;
        private Class[] classes;
        private Group[] groups;


        public static Teacher Construct(String fname, String lname, DateTime[] preferdTime, Class[] classes, Group[] groups) {

            return new Teacher(fname, lname, preferdTime, classes, groups);
        }

        public Teacher(String fname, String lname, DateTime[] preferdTime, Class[] classes, Group[] groups)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.preferdTime = preferdTime;
            this.classes = classes;
            this.groups = groups;
        }

        public String FirstName {
            get {
                return this.firstName;
            }
            set {
                firstName = value;
            } 
        }

        public String LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public DateTime[] PreferdTime
        {
            get
            {
                return this.preferdTime;
            }
            set
            {
                preferdTime = value;
            }
        }

        public Class[] Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }

        public Group[] Groups
        {
            get
            {
                return this.groups;
            }
            set
            {
                groups = value;
            }
        }
    }
}
