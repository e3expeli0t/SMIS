using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMISSecurity;
using SMIS.Scheduler;
using SMIS.DataBase;
using SMISInternal;

namespace SMIS
{
    public partial class Classes : Form
    {
        public static int first;
        public static int second;

        const int CLASS_NAME = 0;
        const int TEACHER_NAME = 1;
        const int GRADE = 2;

        public Classes(AccessLevel level)
        {
            LevelAsserts.ASSERT_ADMIN_ACCESS(level);

            InitializeComponent();

            Teacher[] teachers = ScheduleInit.GetTeachers();

            foreach (Teacher t in teachers)
            {
                this.TeacherName.Items.Add(t.FirstName + " " + t.LastName);
            }
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SmisDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.smisDataSet.Classes);
        }


        private bool EditRow(String name, String teacher, String grade)
        {
            int index = this.ClassesView.CurrentRow.Index;
            try
            {
                this.smisDataSet.Classes.Rows[index][CLASS_NAME] = name;
                this.smisDataSet.Classes.Rows[index][TEACHER_NAME] = teacher;
                this.smisDataSet.Classes.Rows[index][GRADE] = grade;
            }
            catch (Exception e)
            {
                Errors.HandleException(e);
                return false;
            }

            return true;
        }

        private void fillFromRow()
        {
            int index = this.ClassesView.CurrentRow.Index;
            this.ClassName.Text = this.smisDataSet.Classes.Rows[index][CLASS_NAME].ToString();
            this.TeacherName.Text = this.smisDataSet.Classes.Rows[index][TEACHER_NAME].ToString();
            this.Grade.Text = this.smisDataSet.Classes.Rows[index][GRADE].ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (this.smisDataSet.HasChanges())
            {
                this.smisDataSet.AcceptChanges();
            }

            if (!Field.Valid(this.TeacherName.Text, this.ClassName.Text, this.Grade.Text))
            {
                Errors.DisplayMinor("One or more input fields are empty");
                return;
            }

            if (this.TeacherOccupy(this.TeacherName.Text))
            {
                Errors.DisplayMinor("Teacher name must be uniuqe");
                return;
            }

            try
            {
                this.smisDataSet.Classes.AddClassesRow(this.ClassName.Text, this.TeacherName.Text, this.Grade.Text);
            }
            catch (ConstraintException)
            {
                Errors.DisplayMinor("Class name must be uniuqe");
                return;
            }

            this.classesTableAdapter.Update(this.smisDataSet.Classes);
        }

        private bool TeacherOccupy(String teacher_name)
        {

            foreach (DataGridViewRow row in ClassesView.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(teacher_name))
                {
                    row.Cells[1].Style.BackColor = Color.Red;
                    return true;
                }

            }

            return false;
        }

        private void ClassesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.fillFromRow();
                this.Edit.Visible = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                Errors.HandleException(ex);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!this.EditRow(this.ClassName.Text, this.TeacherName.Text, this.Grade.Text))
            {
                Errors.DisplayMinor("An error has occurred while trying to edit classes");
                this.fillFromRow();
            }
            else
            {
                this.Edit.Visible = false;
            }
        }
        private void search()
        {
            if (Field.Valid(this.Search.Text))
            {
                this.classesBindingSource.Filter = String.Format("ClassName='{0}'", this.Search.Text);
            }
            else
            {
                this.classesBindingSource.Filter = "ClassName='' ";
            }
        }

        private void DoSearch_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            this.search();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (this.ClassesView.CurrentRow.Index > this.ClassesView.RowCount)
            {
                Errors.DisplayMinor("There is no data to remove");
                return;
            }

            this.smisDataSet.Classes[this.ClassesView.CurrentRow.Index].Delete();
            this.classesTableAdapter.Update(this.smisDataSet.Classes);
        }
    }
}
