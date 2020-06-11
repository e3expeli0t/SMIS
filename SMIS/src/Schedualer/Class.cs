﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Schedualer
{
    class Class
    {
        Teacher teacher;
        String grade;
        String name;

        public static Class Construct(Teacher teacher, String grade, String name)
        {

            return new Class(teacher, grade, name);
        }

        public Class(Teacher teacher, String grade, String name)
        {
            this.teacher = teacher;
            this.grade = grade;
            this.name = name;
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

        public String Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public Teacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.Teacher = value;
            }
        }

        
   }
}
