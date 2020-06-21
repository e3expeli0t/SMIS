using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    class Teacher
    {
        private String firstName;
        private String lastName;
        private String full_name;
        private String id;

        private AvailableTime time = new AvailableTime(DefaultValues.Week);
        private Class[] classes;
        private Group[] groups;


        public static Teacher Construct(String fname, String lname, String id) {

            return new Teacher(fname, lname, id);
        }

        public Teacher(String fname, String lname, String id)
        {
            this.Time = new AvailableTime(DefaultValues.Week);
            this.firstName = fname;
            this.lastName = lname;
            this.full_name = fname + " " + lname;
            this.id = id;
            this.classes = null;
            this.groups = null;
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

        public String FullName
        {
            get
            {
                return this.full_name;
            }
            set
            {
                full_name = value;
            }
        }

        public String Id
        {
            get
            {
                return this.id;
            }
        }

        public AvailableTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                time = value;
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
