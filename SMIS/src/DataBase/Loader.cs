using System;
using System.Collections.Generic;
using System.Linq;

using SMIS.Scheduler;
using SMISInternal;
using System.Data;

using SMIS.SmisDataSetTableAdapters;
using SMISInternal;

namespace SMIS.DataBase
{
    class ScheduleInit
    {
        private SmisDataSet smisDataSet;
        private TeachersTableAdapter teachers_table;
        private SubjectsTableAdapter subject_table;
        private ClassesTableAdapter classes_table;
        private GroupsTableAdapter groups_table;
        private UnavailableTimeTableAdapter uatime_table;

        private Teachers_SubjectsTableAdapter ts_table;
        private Subjects_ClassesTableAdapter sc_table;

        private Teacher[] teachers;
        private Subject[] subjects;
        private Class[] classes;


        public ScheduleInit(bool suppress_groups = false)
        {
            this.smisDataSet = new SmisDataSet();
            this.teachers_table = new TeachersTableAdapter();
            this.classes_table = new ClassesTableAdapter();
            this.subject_table = new SubjectsTableAdapter();
            this.groups_table = new GroupsTableAdapter();
            this.ts_table = new Teachers_SubjectsTableAdapter();
            this.sc_table = new Subjects_ClassesTableAdapter();
            this.uatime_table = new UnavailableTimeTableAdapter();

            this.smisDataSet.DataSetName = "SmisDataSet";
            this.smisDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;

            this.groups_table.Fill(this.smisDataSet.Groups);
            this.teachers_table.Fill(this.smisDataSet.Teachers);
            this.classes_table.Fill(this.smisDataSet.Classes);
            this.subject_table.Fill(this.smisDataSet.Subjects);

            this.sc_table.Fill(this.smisDataSet.Subjects_Classes);
            this.ts_table.Fill(this.smisDataSet.Teachers_Subjects);
            this.uatime_table.Fill(this.smisDataSet.UnavailableTime);

            if (!this.smisDataSet.UnavailableTime.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no time to load, please try reloading the application or adding teacher time");
            }

            if (!this.smisDataSet.Subjects.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no subjects to load, please try reloading the application or adding subjects");
            }

            if (!this.smisDataSet.Teachers.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no teachers to load, please try reloading the application or adding teachers");
            }

            if (!suppress_groups && !this.smisDataSet.Groups.Any())
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


        public Class[] SetSubjectsClasses(Class[] classes, Subject[] subjects)
        {
            List<Class> final_class = new List<Class>();
            foreach (Class c in classes)
            {
                foreach (Subject s in subjects)
                {
                    if (s.ClassId == c.Name)
                    {
                        c.AddSubject(s);
                    }
                }
                final_class.Add(c);
            }

            return final_class.ToArray();
        }

        //Very ineffecient method
        public Group[] LoadGroups()
        {
            Teacher[] teachers = this.LoadTeachers();
            Dictionary<String, Teacher> id_map = new Dictionary<String, Teacher>();

            foreach (Teacher teacher in teachers)
            {
                //Note: can be collisions
                try
                {
                    id_map.Add(teacher.FirstName + " " + teacher.LastName, teacher);
                }
                catch (Exception e)
                {
                    continue;
                    Console.WriteLine(e);
                }
            }

            Subject[] subjects = this.LoadSubjects();
            Class[] classes = this.LoadClasses(id_map);

            List<Group> groups = new List<Group>();

            foreach (SmisDataSet.GroupsRow group_row in this.smisDataSet.Groups)
            {
                if (group_row.Subjects_ClassesRow == null)
                {
                    Errors.DisplayMinor("Invalid subject-class relations. Please contact the adminastrator");
                    break;
                } 

                groups.Add(
                    Group.Construct (
                        this.LocateTeacher(teachers, group_row.TeachersCode),
                        this.LocateClass(classes, group_row.Subjects_ClassesRow.ClassName.ToString()),
                        this.LocateSubject(subjects, group_row.Subjects_ClassesRow.Subject)
                        )
                    );
            }
            return groups.ToArray();
        }

        private Teacher LocateTeacher(Teacher[] teachers, String id)
        {

            foreach (Teacher te in teachers)
            {
                if (te.Id == id)
                {
                    return te;
                }
            }

            Asserts.ASSERT_NOT_REACHED("Couldn't locate teacher");
            return null;
        }

        private Class LocateClass(Class[] classes, String id)
        {

            foreach (Class c in classes)
            {
                if (c.Name == id)
                {
                    return c;
                }
            }

            Asserts.ASSERT_NOT_REACHED("Couldn't locate class");
            return null;
        }
        private Subject LocateSubject(Subject[] subjects, String id)
        {
            foreach(Subject sub in subjects)
            {
                if (sub.Id == id)
                {
                    return sub;
                }
            }

            Asserts.ASSERT_NOT_REACHED("Couldn't locate subject");
            return null;
        }

        //Extremly reduntend and inefficient 
        public String LocateClassId(String ClassCode)
        {
            if (this.smisDataSet.HasChanges())
            {
                this.smisDataSet.AcceptChanges();
            }

            
            return null;
        }


        public Teacher[] LoadTime(Teacher[] teachers)
        {
            Dictionary<String, Teacher> teacher_map = new Dictionary<string, Teacher>();
            foreach(Teacher t in teachers)
            {
                teacher_map.Add(t.Id, t);

            }
            
            int i_time = 0;
            foreach (SmisDataSet.UnavailableTimeRow r in this.smisDataSet.UnavailableTime.Rows)
            {
                int.TryParse(r.Time, out i_time);
                teacher_map[r.TeacherID].Time.MakeUnAvl(AvailableTime.MakeDays(r.Date), i_time);
            }

            return teacher_map.Values.ToArray();
        }

        public SmisDataSet.TeachersRow LoadTeacherRow(String id)
        {
            foreach (SmisDataSet.TeachersRow r in this.smisDataSet.Teachers.Rows)
            {
                if (r.TeacherID == id)
                {
                    return r;
                }
            }

            return null;
        }

        //todp: remove code duplications 
        public Teacher[] LoadTeachers()
        {
            if (this.smisDataSet.HasChanges())
            {
                this.smisDataSet.AcceptChanges();
            }
            else if (this.teachers != null)
            {
                return this.teachers;
            }

            int TID = 0;
            int FIRST_NAME = 1;
            int LAST_NAME = 2;

            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                teachers.Add(
                         Teacher.Construct(dr[FIRST_NAME].ToString(), dr[LAST_NAME].ToString(), dr[TID].ToString())
                    );
            }

            Asserts.ASSERT(teachers.Any());

            return teachers.ToArray();
        }


        //Note: can be collision in teacher name
        public Class[] LoadClasses(Dictionary<String, Teacher> teachers)
        {

            int NAME = 0;
            int TEACHER = 1;
            int GRADE = 2;

            List<Class> classes = new List<Class>();
            String teacher_id = "";

            foreach (DataRow dr in this.smisDataSet.Classes.Rows)
            {
                teacher_id = dr[TEACHER].ToString();
                if (teacher_id == "")
                {
                    continue;
                }
                if (!teachers.ContainsKey(teacher_id)) {
                    throw new Exception(String.Format("The key '{0}' don't exists", teacher_id));
                }
                classes.Add(
                         Class.Construct(teachers[dr[TEACHER].ToString()], dr[GRADE].ToString(), dr[NAME].ToString())
                    );
            }
            Asserts.ASSERT(classes.Any());

            return classes.ToArray();
        }

        public SmisDataSet.ClassesRow LoadClassRow(String class_name)
        {
            foreach (SmisDataSet.ClassesRow dr in this.smisDataSet.Classes)
            {
                if (dr[0].ToString() == class_name)
                {
                    return dr;
                }
            }

            return null;
        }

        public Subject[] LoadSubjects()
        {
            if (this.smisDataSet.HasChanges())
            {
                this.smisDataSet.AcceptChanges();
            }

            Dictionary<String, Subject> subject_map = new Dictionary<string, Subject>();

            int SUBJECT_NAME = 1;
            int SUBJECT_ID = 0;

            int SC_CLASS_NAME = 2;
            int SC_SUBJECT_NAME = 1;
            int SC_TIME = 3;


            foreach (DataRow dr in this.smisDataSet.Subjects.Rows)
            {
                subject_map.Add(dr[SUBJECT_ID].ToString(),
                        Subject.ConstructBasic(dr[SUBJECT_NAME].ToString(), dr[SUBJECT_ID].ToString())
                    );
            }

            foreach (DataRow sc_dr in this.smisDataSet.Subjects_Classes)
            {
                String name = sc_dr[SC_SUBJECT_NAME].ToString();
                subject_map[name].TotalTime = sc_dr[SC_TIME].ToString();
                subject_map[name].ClassId = sc_dr[SC_CLASS_NAME].ToString();
            }

            foreach (SmisDataSet.Teachers_SubjectsRow ts_row in this.smisDataSet.Teachers_Subjects)
            {
                String name = ts_row.SubjectID;
                subject_map[name].TeacherId = ts_row.TeacherID;
            }

            Asserts.ASSERT(subject_map.Any(), "Empty datatable");

            return subject_map.Values.ToArray();
        }

        public SmisDataSet.SubjectsRow LoadSubjectRow(String id)
        {

            foreach (SmisDataSet.SubjectsRow r in this.smisDataSet.Subjects.Rows)
            {
                if (r.LID == id)
                {
                    return r;
                }
            }

            return null;
        }

        public SmisDataSet.Subjects_ClassesRow LoadSubjectClassRow(String id)
        {
            if (this.smisDataSet.HasChanges())
            {
                this.smisDataSet.AcceptChanges();
            }

            foreach (SmisDataSet.Subjects_ClassesRow r in this.smisDataSet.Subjects_Classes.Rows)
            {
                if (r.ClassName == id)
                {
                    return r;
                }
            }

            return null;
        }

        //-----------------------------------------------------------------------------------------------------------------------
        // Static loader functions

        /*
            All static loader functions start with the Word Get.
            They are used in cases when loading the al database into memory is not needed
        */
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

            int TID = 0;
            int FIRST_NAME = 1;
            int LAST_NAME = 2;

            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in ds.Teachers.Rows)
            {
                teachers.Add(
                         Teacher.Construct(dr[FIRST_NAME].ToString(), dr[LAST_NAME].ToString(), dr[TID].ToString())
                    );
            }

            Asserts.ASSERT(teachers.Any());

            return teachers.ToArray();
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

            foreach (SmisDataSet.ClassesRow dr in ds.Classes)
            {
                if (dr[0].ToString() == class_name)
                {
                    return dr;
                }
            }

            return null;
        }

        public static Subject[] GetSubjects()
        {
            SmisDataSet ds = new SmisDataSet();
            SubjectsTableAdapter subject_table = new SubjectsTableAdapter();
            Subjects_ClassesTableAdapter sc_table = new Subjects_ClassesTableAdapter();


            subject_table.Fill(ds.Subjects);
            sc_table.Fill(ds.Subjects_Classes);

            if (!ds.Subjects.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr there is no subjects to load, please try reloading the application or adding subjects");
            }

            if (!ds.Subjects_Classes.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr subjects-classes relations dont exists, please try reloading the application or adding these relations");

            }

            if (ds.HasChanges())
            {
                ds.AcceptChanges();
            }

            Dictionary<String, Subject> subject_map = new Dictionary<string, Subject>();

            int SUBJECT_NAME = 1;
            int SUBJECT_ID = 0;

            int SC_CLASS_NAME = 2;
            int SC_SUBJECT_NAME = 1;
            int SC_TIME = 3;


            foreach (DataRow dr in ds.Subjects.Rows)
            {
                subject_map.Add(dr[SUBJECT_ID].ToString(),
                        Subject.ConstructBasic(dr[SUBJECT_NAME].ToString(), dr[SUBJECT_ID].ToString())
                    );
            }

            foreach (DataRow sc_dr in ds.Subjects_Classes)
            {
                String name = sc_dr[SC_SUBJECT_NAME].ToString();
                subject_map[name].TotalTime = sc_dr[SC_TIME].ToString();
                subject_map[name].ClassId = sc_dr[SC_CLASS_NAME].ToString();
            }

            Asserts.ASSERT(subject_map.Any(), "Empty datatable");

            return subject_map.Values.ToArray();
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

        public static SmisDataSet.Subjects_ClassesRow GetSubjectClassRow(String id)
        {

            SmisDataSet ds = new SmisDataSet();
            Subjects_ClassesTableAdapter sc_table = new Subjects_ClassesTableAdapter();

            sc_table.Fill(ds.Subjects_Classes);

            if (!ds.Subjects_Classes.Any())
            {
                Errors.DisplayMajor("Database didn't load properly.\nOr subjects-classes relations dont exists, please try reloading the application or adding these relations");

            }

            if (ds.HasChanges())
            {
                ds.AcceptChanges();
            }

            foreach (SmisDataSet.Subjects_ClassesRow r in ds.Subjects_Classes.Rows)
            {
                if (r.ClassName == id)
                {
                    return r;
                }
            }

            return null;
        }
    }
}