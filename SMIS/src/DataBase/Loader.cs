using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SMIS.Schedualer;
using SMISInternal;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;


using SMIS.SmisDataSetTableAdapters;

namespace SMIS.DataBase
{
    class ScheduleInit
    {
        private SmisDataSet smisDataSet;
        private TeachersTableAdapter teachers_table;
        private SubjectsTableAdapter subject_table;
        private ClassesTableAdapter clasess_table;
        private GroupsTableAdapter groups_table;

        private Teachers_SubjectsTableAdapter ts_table;
        private Subjects_ClassesTableAdapter sc_table;

        public ScheduleInit() {
            this.smisDataSet = new SmisDataSet();

            this.smisDataSet.DataSetName = "SmisDataSet";
            this.smisDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;

            this.groups_table.Fill(this.smisDataSet.Groups);
            this.teachers_table.Fill(this.smisDataSet.Teachers);
            this.clasess_table.Fill(this.smisDataSet.Classes);
            this.subject_table.Fill(this.smisDataSet.Subjects);

            this.sc_table.Fill(this.smisDataSet.Subjects_Classes);
            this.ts_table.Fill(this.smisDataSet.Teachers_Subjects);

            if (!this.smisDataSet.Subjects.Any()) {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no subjects to load, please try reloading the application or adding subjects");
            }

            if (!this.smisDataSet.Teachers.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no teachers to load, please try reloading the application or adding teachers");
            }

            if (!this.smisDataSet.Groups.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no groups to load, please try reloading the application or adding groups");
            }

            if (!this.smisDataSet.Classes.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no classes to load, please try reloading the application or adding classes");
            }

            if (!this.smisDataSet.Teachers_Subjects.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr teachers-subjects relations dont exists, please try reloading the application or adding these relations");

            }

            if (!this.smisDataSet.Subjects_Classes.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr subjects-classes relations dont exists, please try reloading the application or adding these relations");

            }

        }

        public void Reset() {
            this.smisDataSet.Reset();
        }

        // todo: Add times to teacher object
        public Teacher[] GetTeachers() 
        {
            int FIRST_NAME = 1;
            int LAST_NAME = 2;

            List<Teacher> teachers = new List<Teacher>();
            foreach ( DataRow dr in this.smisDataSet.Teachers.Rows) {
                teachers.Add(
                         Teacher.Construct(dr[FIRST_NAME].ToString(), dr[LAST_NAME].ToString(), dr[0].ToString())
                    );
            } 

            Asserts.ASSERT(teachers.Any());

            return teachers.ToArray();
        }


        //Todo: This shoud handle only ID
        public Teacher GetTeacherByName(String name) {

            Teacher teacher;

            int FIRST_NAME = 1;
            int LAST_NAME = 2;

            foreach (DataRow row in this.smisDataSet.Teachers.Rows) {
                if (row[FIRST_NAME].ToString() + " " + row[LAST_NAME].ToString() == name) {
                    teacher = Teacher.Construct(
                        )
                }
            }
        }

        public bool TeacherExistsStrong(String id = "") {
            Asserts.ASSERT(id.Any(), "Can't search for empty id");

            foreach (DataRow dr in this.smisDataSet.Teachers.Rows) {
                if (dr[0].ToString() == id) {
                    return true;
                }
            }

            return false;
        }

        public Class[] GetClasses()
        {
            int NAME = 0;
            int TEACHER = 1;
            int GRADE = 2;
            

            List<Classes> teachers = new List<Classes>();
            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                teachers.Add(
                         Class.Construct(dr[TEACHER].ToString(), dr[GRADE].ToString() , dr[NAME].ToString())
                    );
            }

            Asserts.ASSERT(teachers.Any());

            return teachers.ToArray();
        }

        public bool TeacherExistsStrong(String id = "")
        {
            Asserts.ASSERT(id.Any(), "Can't search for empty id");

            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                if (dr[0].ToString() == id)
                {
                    return true;
                }
            }

            return false;
        }

        public bool TeacherExistsSoft(String fname, String lname)
        {
            Asserts.ASSERT(fname.Any() && lname.Any(), "Can't search for empty name");
            int FIRST_NAME = 1;
            int LAST_NAME = 2;


            Debug.WriteLine(fname, lname);

            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                if (dr[FIRST_NAME].ToString() == fname.Trim() && dr[LAST_NAME].ToString() == lname.Trim())
                {
                    return true;
                }
            }

            Asserts.ASSERT_NOT_REACHED();

            return false;
        }


        public Teacher[] GetTeachers()
        {
            int FIRST_NAME = 1;
            int LAST_NAME = 2;

            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                teachers.Add(
                         Teacher.Construct(dr[FIRST_NAME].ToString(), dr[LAST_NAME].ToString(), dr[0].ToString())
                    );
            }

            Asserts.ASSERT(teachers.Any());

            return teachers.ToArray();
        }

        public bool TeacherExistsStrong(String id = "")
        {
            Asserts.ASSERT(id.Any(), "Can't search for empty id");

            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                if (dr[0].ToString() == id)
                {
                    return true;
                }
            }

            return false;
        }

        public bool TeacherExistsSoft(String fname, String lname)
        {
            Asserts.ASSERT(fname.Any() && lname.Any(), "Can't search for empty name");
            int FIRST_NAME = 1;
            int LAST_NAME = 2;


            Debug.WriteLine(fname, lname);

            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                if (dr[FIRST_NAME].ToString() == fname.Trim() && dr[LAST_NAME].ToString() == lname.Trim())
                {
                    return true;
                }
            }

            Asserts.ASSERT_NOT_REACHED();

            return false;
        }
    }
}
