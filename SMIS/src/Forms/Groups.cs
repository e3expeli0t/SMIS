using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SMIS.Scheduler;
using SMIS.DataBase;
using SMISSecurity;
using SMISInternal;

namespace SMIS
{
    public partial class Groups : Form
    {
        private ScheduleInit pre_scheduler = new ScheduleInit(true);
        private Dictionary<String, String> id_map = new Dictionary<String, String>();
        private Dictionary<String, String> class_map = new Dictionary<String, String>();
        private Dictionary<String, Subject> subject_map = new Dictionary<String, Subject>();

        private Teacher[] teachers;
        private Subject[] subjects;
        private Class[] classes;

        public Groups(AccessLevel level)
        {
            LevelAsserts.ASSERT_ADMIN_ACCESS(level);
            Cursor.Current = Cursors.WaitCursor;

            InitializeComponent();

            // Fill all the ComboBoxes

            Teacher[] teachers = pre_scheduler.LoadTeachers();
            Dictionary<String, Teacher> name_map = new Dictionary<string, Teacher>();

            //Note: there is big problem since in the classes form we are using
            // Name as teacher refrence( should be resolved to id)
            foreach (Teacher t in teachers)
            {
                this.id_map.Add(t.FirstName + " " + t.LastName, t.Id);
                this.TeacherSelector.Items.Add(t.FirstName + " " + t.LastName);
                name_map.Add(t.FirstName + " " + t.LastName, t);
            }

            Class[] classes = this.pre_scheduler.LoadClasses(name_map);

            foreach (Class c in classes)
            {
                this.class_map.Add(c.Name, c.Teacher.FirstName + " " + c.Teacher.LastName);
                this.ClassSelector.Items.Add(c.Name);
            }

            Subject[] subjects = this.pre_scheduler.LoadSubjects();

            foreach (Subject s in subjects)
            {
                this.SubjectSelector.Items.Add(s.Name);
                this.subject_map.Add(s.Name, s);
            }

            this.classes = this.pre_scheduler.SetSubjectsClasses(classes, subjects);
            this.subjects = subjects;
            Cursor.Current = Cursors.Default;
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.smisDataSet.Groups);
        }

        private void DoAdd_Click(object sender, EventArgs e)
        {
            //Asserts.ASSERT_NOT_REACHED();
            if (this.TeacherSelector.SelectedIndex < 0)
            {
                Errors.DisplayMinor("Please select teacher");
                return;
            }

            if (this.SubjectSelector.SelectedIndex < 0)
            {
                Errors.DisplayMinor("Please select subject");
                return;
            }

            if (this.ClassSelector.SelectedIndex < 0)
            {
                Errors.DisplayMinor("Please select class");
                return;
            }

            String class_name = this.ClassSelector.Text;

            int asked_duration = 0;
            int.TryParse(this.Duration.Text, out asked_duration);
            if (asked_duration == 0)
            {
                Errors.DisplayMinor("Please choose duration");
                return;
            }

            Class c;
            if (!this.getClassByName(class_name, out c))
            {
                Errors.DisplayMajor("Internal error: Couldn't locate class.\n Try reloading the application");
                return;
            }

            Subject current_subject = c.GetSubject(this.SubjectSelector.Text);
            if (current_subject == null)
            {
                Errors.DisplayMinor("Class don't have this subject assigned");
                return;
            }

            String teacher_name = this.TeacherSelector.Text;
            if (!current_subject.HasTeacherAssigned(this.id_map[teacher_name]))
            {
                Errors.DisplayMinor(String.Format("The teacher '{0}' can't teach subject '{1}'", teacher_name, current_subject.Name));
                return;
            }

            int possible_time = Convert.ToInt32(current_subject.TotalTime);
            
            if (possible_time < asked_duration)
            {
                Errors.DisplayMinor(String.Format("Duration can't be bigger then: {0}", possible_time.ToString()));
                return;
            }
            

            SmisDataSet.TeachersRow teacher_row = this.pre_scheduler.LoadTeacherRow(
                    this.id_map[teacher_name]
                );
            SmisDataSet.Subjects_ClassesRow subject_row = this.pre_scheduler.LoadSubjectClassRow(class_name);

            Asserts.ASSERT(teacher_row != null || subject_row != null, "Error while loading Tables\n try restarting the application");

            this.smisDataSet.Groups.AddGroupsRow(
                    subject_row,
                    (possible_time - asked_duration).ToString(),
                    asked_duration.ToString(),
                    teacher_row
                );
            this.groupsTableAdapter.Update(this.smisDataSet.Groups);
        }

        private void Duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private Boolean getClassByName(string name, out Class s)
        {
            foreach (Class c in this.classes)
            {
                if (c.Name == name)
                {

                    s = c; ;
                    return true;
                }
            }

            s = null;
            return false;
        }

        private void SubjectSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PossibleTime.Text = this.subject_map[this.SubjectSelector.Text].TotalTime;
        }

        private void ClassSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
