using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMISSecurity;

namespace SMIS
{
    public partial class Subjects : Form
    {

        private int index = 0;

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
            RandomString.SetSeed(this.Subject.Text);
            String id = RandomString.Generate();
            this.smisDataSet.Subjects.AddSubjectsRow(id, this.Subject.Text);
            this.subjectsTableAdapter.Update(this.smisDataSet.Subjects);
            this.smisDataSet.AcceptChanges();
        }

        private void DoEdit_Click(object sender, EventArgs e)
        {
            this.smisDataSet.Subjects.Rows[index][1] = this.Subject.Text;
            this.subjectsTableAdapter.Update(this.smisDataSet.Subjects);
        }

        private void SubjectsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DoEdit.Visible = true;
            index = this.SubjectsView.CurrentRow.Index;
            this.fillFromRow();
        }
    }
}
