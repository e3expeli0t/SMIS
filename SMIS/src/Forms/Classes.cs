using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMISSecurity;
using SMISInternal;

namespace SMIS
{

    public partial class Classes : Form, DBControl.DBElement<String, Object>
    {

        const int CLASS_NAME = 0;
        const int TEACHER_NAME = 1;
        const int GRADE = 2;

        public Classes(AccessLevel level)
        {
            if (level != AccessLevel.Admin)
            {
                //FIXME: caller must handle this exception
                throw new UnauthorisedUserExecption("Invalid accsess to classes dataset");
            }

            InitializeComponent();
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SmisDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.SmisDataSet.Classes);
        }


        private bool EditRow(String name, String teacher, String grade) 
        {

            int index = this.ClassesView.CurrentRow.Index;
            try
            {
                this.SmisDataSet.Classes.Rows[index][CLASS_NAME] = name;
                this.SmisDataSet.Classes.Rows[index][TEACHER_NAME] = teacher;
                this.SmisDataSet.Classes.Rows[index][GRADE] = grade;
            }
            catch (Exception e)
            {
                SMISInternal.Errors.HandleException(e);
                return false;
            }

            return true;
        }

        private void fillFromRow()
        {
            int index = this.ClassesView.CurrentRow.Index;
            this.ClassName.Text = this.SmisDataSet.Classes.Rows[index][CLASS_NAME].ToString();
            this.TeacherName.Text = this.SmisDataSet.Classes.Rows[index][TEACHER_NAME].ToString();
            this.Grade.Text = this.SmisDataSet.Classes.Rows[index][GRADE].ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!Field.Valid(this.TeacherName.Text, this.ClassName.Text, this.Grade.Text))
            {
                Errors.DisplayMinor("One or more input fields are empty");
                return;
            }

            //todo: check for valid grade
            if (!Teachers.exist(this.TeacherName.Text))
            {
                SMISInternal.Errors.DisplayMinor(
                    String.Format("Couldn't find teacher '{0}'", this.TeacherName.Text)
                    );
                return;
            }

            try
            {
                this.SmisDataSet.Classes.AddClassesRow(this.ClassName.Text, this.TeacherName.Text, this.Grade.Text);
            }
            catch (ConstraintException ex) {
                Errors.DisplayMinor("Class name must be uniuqe");
                return;
            } 
                
            this.classesTableAdapter.Update(this.SmisDataSet.Classes);
        }

        private void ClassesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.fillFromRow();
                this.Edit.Visible = true;
            }
            catch (IndexOutOfRangeException ex) {
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


        //DBElement interface
        public bool exist(string elem)
        {
            throw new NotImplementedException();
        }

        public object lookup(string elem)
        {
            throw new NotImplementedException();
        }

        private void DoSearch_Click(object sender, EventArgs e)
        {
            if (Field.Valid(this.Search.Text))
            {
                this.classesBindingSource.Filter = String.Format("ClassName like '{0}'", this.Search.Text);
            }
            else {

                this.classesBindingSource.Filter = "ClassName like '*'";
            }
        }

    }
}
