﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SMIS.Scheduler;
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

        private bool valid = true;

        public ScheduleInit()
        {
            this.smisDataSet = new SmisDataSet();

            this.smisDataSet.DataSetName = "SmisDataSet";
            this.smisDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;

            this.groups_table.Fill(this.smisDataSet.Groups);
            this.teachers_table.Fill(this.smisDataSet.Teachers);
            this.clasess_table.Fill(this.smisDataSet.Classes);
            this.subject_table.Fill(this.smisDataSet.Subjects);

            this.sc_table.Fill(this.smisDataSet.Subjects_Classes);
            this.ts_table.Fill(this.smisDataSet.Teachers_Subjects);

            if (!this.smisDataSet.Subjects.Any())
            {
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

        public void Reset()
        {
            this.smisDataSet.Reset();
        }


        public static SmisDataSet.TeachersRow GetTeacherRow(String id)
        {
            SmisDataSet ds = new SmisDataSet();
            TeachersTableAdapter teachers_table = new TeachersTableAdapter();

            teachers_table.Fill(ds.Teachers);
            if (!ds.Teachers.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no teachers to load, please try reloading the application or adding teachers");
            }

            foreach (SmisDataSet.TeachersRow r in ds.Teachers.Rows)
            {
                if (r.TeacherID == id)
                {
                    return r;
                }
            }

            return null;
        }

        //todp: remove code duplications 
        public static Teacher[] GetTeachers()
        {
            SmisDataSet ds = new SmisDataSet();
            TeachersTableAdapter teachers_table = new TeachersTableAdapter();

            teachers_table.Fill(ds.Teachers);
            if (!ds.Teachers.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no teachers to load, please try reloading the application or adding teachers");
            }

            int FIRST_NAME = 1;
            int LAST_NAME = 2;

            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in ds.Teachers.Rows)
            {
                teachers.Add(
                         Teacher.Construct(dr[FIRST_NAME].ToString(), dr[LAST_NAME].ToString(), dr[0].ToString())
                    );
            }

            Asserts.ASSERT(teachers.Any());

            return teachers.ToArray();
        }


        //Note: can be collision in teacher name
        public static Class[] GetClasses(Dictionary<String, Teacher> teachers)
        {
            SmisDataSet ds = new SmisDataSet();
            ClassesTableAdapter clasess_table = new ClassesTableAdapter();

            clasess_table.Fill(ds.Classes);

            if (!ds.Classes.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no classes to load, please try reloading the application or adding classes");
            }

            int NAME = 0;
            int TEACHER = 1;
            int GRADE = 2;


            List<Class> classes = new List<Class>();

            foreach (DataRow dr in ds.Classes.Rows)
            {
                classes.Add(
                         Class.Construct(teachers[dr[TEACHER].ToString()], dr[GRADE].ToString(), dr[NAME].ToString())
                    );
            }

            Asserts.ASSERT(teachers.Any());

            return classes.ToArray();
        }

        public static SmisDataSet.ClassesRow GetClassRow(String class_name)
        {
            SmisDataSet ds = new SmisDataSet();
            ClassesTableAdapter clasess_table = new ClassesTableAdapter();

            clasess_table.Fill(ds.Classes);

            if (!ds.Classes.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no classes to load, please try reloading the application or adding classes");
            }

            foreach (SmisDataSet.ClassesRow dr in ds.Classes) {
                if (dr[0].ToString() == class_name) {
                    return dr;
                }
            }

            return null;
        }

        public static Subject[] GetSubjects()
        {
            SmisDataSet ds = new SmisDataSet();
            SubjectsTableAdapter subject_table = new SubjectsTableAdapter();

            subject_table.Fill(ds.Subjects);

            List<Subject> subjects = new List<Subject>();

            if (!ds.Subjects.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no subjects to load, please try reloading the application or adding subjects");
            }

            if (ds.HasChanges())
            {
                ds.AcceptChanges();
            }

            foreach (DataRow dr in ds.Subjects.Rows)
            {
                subjects.Add(
                         Subject.Construct(dr[1].ToString(), dr[0].ToString())
                    );
            }

            Asserts.ASSERT(subjects.Any(), "Empty datatable");

            return subjects.ToArray();
        }

        public static SmisDataSet.SubjectsRow GetSubjectRow(String id)
        {

            SmisDataSet ds = new SmisDataSet();
            SubjectsTableAdapter subject_table = new SubjectsTableAdapter();

            subject_table.Fill(ds.Subjects);
            
            if (!ds.Subjects.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no subjects to load, please try reloading the application or adding subjects");
            }

            foreach (SmisDataSet.SubjectsRow r in ds.Subjects.Rows)
            {
                if (r.LID == id)
                {
                    return r;
                }
            }

            return null;
        }

    }
}
