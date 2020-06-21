using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.Scheduler
{
    class Class
    {
        //todo: replace teacher with teacher_id
        Teacher teacher;
        List<Subject> subjects = new List<Subject>();
        String grade;
        String name;


        // Final version of construct
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

        public void AddSubject(Subject s) {
            this.subjects.Add(s);
        }

        public bool HasSubject(String name) {
            return this.GetSubject(name) != null;
        }
        
        public Subject GetSubject(String name)
        {
            foreach(Subject s in this.Subjects)
            {
                if (s.Name == name) {
                    return s;
                }
            }

            return null;   
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

        public List<Subject> Subjects
        {
            get
            {
                return this.subjects;
            }

            set
            {
                this.subjects = value;
            }

        }

        
   }
}
