using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMISSecurity;
using SMIS.DataBase;
using SMISInternal;

namespace SMIS
{

    public partial class Classes : Form
    {

        const int CLASS_NAME = 0;
        const int TEACHER_NAME = 1;
        const int GRADE = 2;

        private TeachersDBTable tDBTable;

        public Classes(AccessLevel level)
        {
            LevelAsserts.ASSERT_ADMIN_ACCESS(level);

            InitializeComponent();
            this.tDBTable = new TeachersDBTable();
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
            if (!Field.Valid(this.TeacherName.Text, this.ClassName.Text, this.Grade.Text))
            {
                Errors.DisplayMinor("One or more input fields are empty");
                return;
            }

            Dictionary<String, String> names = this.parseName();

            if (Name == null) {
                return;
            }

            //todo: check for valid grade
            if (!this.tDBTable.Exists(names["first_name"]+" "+names["last_name"]))
            {
                Errors.DisplayMajor(String.Format("Couldn't find teacher named '{}'. please check agian.", this.TeacherName.Text));
                return;
            }


            try
            {
                this.smisDataSet.Classes.AddClassesRow(this.ClassName.Text, this.TeacherName.Text, this.Grade.Text);
            }
            catch (ConstraintException ex)
            {
                Errors.DisplayMinor("Class name must be uniuqe");
                return;
            }

            this.classesTableAdapter.Update(this.smisDataSet.Classes);

            this.smisDataSet.AcceptChanges();
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
                this.classesBindingSource.Filter = String.Format("ClassName like % '{0}'", this.Search.Text);
            }
            else
            {
                this.classesBindingSource.Filter = "ClassName like % ";
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

        private Dictionary<String, String> parseName()
        {
            String[] names = this.TeacherName.Text.Split(' ', '\t');

            if (names.Length < 2)
            {
                Errors.DisplayMinor("Please supply full name.");
                return null;
            }

            String firstName = names[0];
            String lastName = names[1];

            if (names.Length > 2)
            {
                lastName = names.LastOrDefault();
                names = names.Take(names.Length - 1).ToArray();

                firstName = "";
                foreach (String name in names)
                {
                    firstName += name + " ";
                }

                firstName = firstName.Take(firstName.Length - 1).ElementAt(0).ToString();
            }
            Dictionary<string, string> names_dict = new Dictionary<string, string>();

            names_dict.Add("first_name", firstName);
            names_dict.Add("last_name", lastName);

            return names_dict;
        }
    }
}
