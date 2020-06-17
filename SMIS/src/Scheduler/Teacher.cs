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
        private String id;
        private DateTime[] preferdTime;
        private Class[] classes;
        private Group[] groups;


        public static Teacher Construct(String fname, String lname, String id) {

            return new Teacher(fname, lname, id);
        }

        public Teacher(String fname, String lname, String id)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.preferdTime = null;
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

        public String Id
        {
            get
            {
                return this.id;
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
