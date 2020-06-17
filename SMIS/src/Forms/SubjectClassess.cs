using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SMISInternal;
using SMISSecurity;
using SMIS.Scheduler;
using SMIS.DataBase;


namespace SMIS
{
    public partial class SubjectClassess : Form
    {

        private Dictionary<String, String> subject_id_map = new Dictionary<string, string>();

        public SubjectClassess()
        {
            InitializeComponent();

            // Initialize the selectors

            Subject[] subjects = ScheduleInit.GetSubjects();

            //Note: subject name must be uniuqe, so we dont check for key duplication here
            foreach (Subject s in subjects)
            {
                this.SubjectSelector.Items.Add(s.Name);
                this.subject_id_map[s.Name] = s.Id;
            }


            Dictionary<String, Teacher> name_map = new Dictionary<string, Teacher>();

            //Note: there is big problem since in the classes form we are using
            // Name as teacher refrence( should be resolved to id)
            foreach (Teacher t in ScheduleInit.GetTeachers())
            {
                name_map.Add(t.FirstName + " " + t.LastName, t);
            }


            Class[] classes = ScheduleInit.GetClasses(name_map);

            foreach (Class c in classes) {
                this.ClassSelector.Items.Add(c.Name);
            }
        }

        private void SubjectClassess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Subjects_Classes' table. You can move, or remove it, as needed.
            this.subjects_ClassesTableAdapter.Fill(this.smisDataSet.Subjects_Classes);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DoAdd_Click(object sender, EventArgs e)
        {
            if (this.SubjectSelector.SelectedIndex < 0 && this.ClassSelector.SelectedIndex < 0) {
                Errors.DisplayMinor("Please select class and subject");
            }

            int total = 0;
            int.TryParse(this.TotalTime.Text, out total);

            if (total > 4) {
                Errors.DisplayMinor("The maximum number of hours (i.e 45 mins) for subject is 4");
                return;
            }

            SmisDataSet.SubjectsRow subject_row = ScheduleInit.GetSubjectRow(this.subject_id_map[this.SubjectSelector.Text]);

            if (subject_row == null) {
                Errors.DisplayMajor("Error while loading data from application.\nPlease reload the application");
            }

            SmisDataSet.ClassesRow class_row = ScheduleInit.GetClassRow(this.ClassSelector.Text);


            this.smisDataSet.Subjects_Classes.AddSubjects_ClassesRow(subject_row, class_row, total.ToString());
            this.subjects_ClassesTableAdapter.Update(this.smisDataSet.Subjects_Classes);
        }
    }
}
