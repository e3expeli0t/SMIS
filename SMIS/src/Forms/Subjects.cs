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
    public partial class Subjects : Form
    {

        private int index = 0;
        private bool edit_mode = false;

        public Subjects(AccessLevel level)
        {
            LevelAsserts.ASSERT_ADMIN_ACCESS(level);

            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.smisDataSet.Subjects);
        }

        private void fillFromRow() {
            this.Subject.Text = this.smisDataSet.Subjects.Rows[index][1].ToString();
        }

        private void DoSave_Click(object sender, EventArgs e)
        {
            if (this.smisDataSet.HasChanges())
            {
                this.smisDataSet.AcceptChanges();
            } 

            if (this.SubjectOccupy(this.Subject.Text)) {
                Errors.DisplayMinor("Subject exists. subject name must be uniuqe.");
                return;
            }

            RandomString.SetSeed(this.Subject.Text);
            String id = RandomString.Generate();

            this.smisDataSet.Subjects.AddSubjectsRow(id, this.Subject.Text);
            this.subjectsTableAdapter.Update(this.smisDataSet.Subjects);
        }

        private void DoEdit_Click(object sender, EventArgs e)
        {
            this.smisDataSet.Subjects.Rows[index][1] = this.Subject.Text;
            this.subjectsTableAdapter.Update(this.smisDataSet.Subjects);
        }

        private void cancelEdit() {
            this.edit_mode = false;
            this.DoRemove.Text = "delete";
            this.DoEdit.Visible = false;
        }
        private bool SubjectOccupy(String subject_name)
        {
            if (this.SubjectsView.Rows.Count ==  0) {
                return false;
            }

            foreach (DataGridViewRow row in SubjectsView.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(subject_name))
                {
                    row.Cells[1].Style.BackColor = Color.Red;
                    return true;
                }
            }

            return false;
        }

        private void SubjectsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DoRemove.Text = "cancel";
            this.DoEdit.Visible = true;
            this.edit_mode = true;
            index = this.SubjectsView.CurrentRow.Index;
            this.fillFromRow();
        }

        private void DoRemove_Click(object sender, EventArgs e)
        {
            if (edit_mode) {
                cancelEdit();
                return;
            }

            this.smisDataSet.Subjects[this.SubjectsView.CurrentRow.Index].Delete();
            this.subjectsTableAdapter.Update(this.smisDataSet.Subjects);
        }
    }
}
