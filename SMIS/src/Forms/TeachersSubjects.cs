using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SMISSecurity;
using SMIS.DataBase;
using SMIS.Scheduler;
using SMISInternal;
using System.Threading;

namespace SMIS
{
    public partial class TeachersSubjects : Form
    {
        private Dictionary<String, String> teacher_id_map = new Dictionary<String, String>();
        private Dictionary<String, String> subject_id_map = new Dictionary<String, String>();
        private bool edit_mode = false;

        public TeachersSubjects(AccessLevel level)
        {
            try
            {
                LevelAsserts.ASSERT_ADMIN_ACCESS(level);

                InitializeComponent();


                Teacher[] teachers = ScheduleInit.GetTeachers();
                String full_name;
                int key_dup = 0;

                foreach (Teacher t in teachers)
                {
                    full_name = t.FirstName + " " + t.LastName;

                    if (this.teacher_id_map.ContainsKey(full_name))
                    {
                        full_name += "_" + key_dup;
                        ++key_dup;
                    }

                    this.TeacherSelection.Items.Add(full_name);
                    this.teacher_id_map[full_name] = t.Id;
                }

                Subject[] subjects = ScheduleInit.GetSubjects();

                //Note: subject name must be uniuqe, so we dont check for key duplication here
                foreach (Subject s in subjects)
                {
                    this.SubjectSelection.Items.Add(s.Name);
                    this.subject_id_map[s.Name] = s.Id;
                }
            }
            catch {
                Errors.DisplayMajor("Reload needed!");
                this.SuspendLayout();
            }
        }

        private void TeachersSubjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Teachers_Subjects' table. You can move, or remove it, as needed.
            this.teachers_SubjectsTableAdapter.Fill(this.smisDataSet.Teachers_Subjects);
        }

        private void DoEdit_Click(object sender, EventArgs e)
        {
            Errors.DisplayMajor("This data is imutable.");

            this.DoEdit.Visible = false;
            this.DoRemove.Visible = true;
        }

        private void DoRemove_Click(object sender, EventArgs e)
        {
            if (this.edit_mode) {
                this.cancelEdit();
            }

            this.smisDataSet.Subjects[this.TeachersSubjectsView.CurrentRow.Index].Delete();
            this.teachers_SubjectsTableAdapter.Update(this.smisDataSet.Teachers_Subjects);
        }

        private void DoAdd_Click(object sender, EventArgs e)
        {
            if (this.TeacherSelection.SelectedIndex < 0) {
                Errors.DisplayMinor("Please select teacher");
                return;
            }

            if (this.SubjectSelection.SelectedIndex < 0)
            {
                Errors.DisplayMinor("Please select subject");
                return;
            }

            if (this.smisDataSet.HasChanges()) {
                this.smisDataSet.AcceptChanges();
            }

            if (!this.teacher_id_map.ContainsKey(this.TeacherSelection.Text)) {
                Errors.DisplayMajor(String.Format("Invalid teacher name: '{0}'", this.TeacherSelection.Text));
            }

            if (!this.subject_id_map.ContainsKey(this.SubjectSelection.Text))
            {
                Errors.DisplayMajor(String.Format("Invalid subject name: '{0}'", this.SubjectSelection.Text));
            }
            String teacher_name = this.TeacherSelection.Text;
            String id = this.teacher_id_map[teacher_name];

            SmisDataSet.TeachersRow teacher_row = ScheduleInit.GetTeacherRow(id);
            SmisDataSet.SubjectsRow subject_row = ScheduleInit.GetSubjectRow(this.subject_id_map[this.SubjectSelection.Text]);

            this.smisDataSet.Teachers_Subjects.AddTeachers_SubjectsRow(subject_row, teacher_row);
            this.teachers_SubjectsTableAdapter.Update(this.smisDataSet.Teachers_Subjects);
        }

        private void TeacherSubjectsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DoEdit.Visible = true;
            this.DoRemove.Text = "Cancel editing";
            this.edit_mode = true;
        }

        private void cancelEdit() {
            this.edit_mode = false;
            this.DoEdit.Visible = false;
            this.DoRemove.Text = "Remove";
        }
    }
}
