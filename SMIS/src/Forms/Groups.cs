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

            Teacher[] teachers = ScheduleInit.GetTeachers();
            Dictionary<String, Teacher> name_map = new Dictionary<string, Teacher>();

            //Note: there is big problem since in the classes form we are using
            // Name as teacher refrence( should be resolved to id)
            foreach (Teacher t in teachers)
            {
                this.id_map.Add(t.FirstName + " " + t.LastName, t.Id);
                this.TeacherSelector.Items.Add(t.FirstName + " " + t.LastName);
                name_map.Add(t.FirstName + " " + t.LastName, t);
            }

            Class[] classes = ScheduleInit.GetClasses(name_map);

            foreach (Class c in classes)
            {
                this.class_map.Add(c.Name, c.Teacher.FirstName + " " + c.Teacher.LastName);
                this.ClassSelector.Items.Add(c.Name);
            }

            Subject[] subjects = ScheduleInit.GetSubjects();

            foreach (Subject s in subjects) {
                this.SubjectSelector.Items.Add(s.Name);
                this.subject_map.Add(s.Name, s);
            }


            this.subjects = subjects;
            Cursor.Current = Cursors.Default;
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.smisDataSet.Groups);
        }

        private void ClassSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TeacherSelector.Text = this.class_map[this.ClassSelector.Text];
        }

        private void DoAdd_Click(object sender, EventArgs e)
        {
            String subject_name = this.SubjectSelector.Text;

            int asked_duration = 0;
            int.TryParse(this.Duration.Text, out asked_duration);

            Subject s;
            if (!this.getSubjectByName(subject_name, out s)) {
                Errors.DisplayMajor("Internal error: Couldn't locate subject.\n Try reloading the application");
                return;
            }

            int possible_time = Convert.ToInt32(s.TotalTime);

            if ( possible_time < asked_duration) {
                Errors.DisplayMinor(String.Format("Duration can't be bigger then: {}", possible_time.ToString()));
                return;
            }

            String teacher_name = this.TeacherSelector.Text;
            SmisDataSet.TeachersRow teacher_row = ScheduleInit.GetTeacherRow(this.id_map[teacher_name]);
            SmisDataSet.Subjects_ClassesRow subject_row  = ScheduleInit.GetSubjectClassRow(subject_name);

            Asserts.ASSERT(teacher_row != null && subject_row != null, "Error while loading Tables\n try restarting the application");

            this.smisDataSet.Groups.AddGroupsRow(
                subject_row,
                (possible_time - asked_duration).ToString(),
                asked_duration.ToString(),
                teacher_row);            
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

        private Boolean getSubjectByName(string name, out Subject s) {
            foreach (Subject sub in this.subjects) {
                if (sub.Name == name) {

                    s = sub;
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
    }
}
