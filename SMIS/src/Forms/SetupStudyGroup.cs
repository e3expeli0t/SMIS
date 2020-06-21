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
    public partial class SetupStudyGroup : Form
    {
        private AccessLevel ac_level = AccessLevel.Default;
        public SetupStudyGroup(AccessLevel level)
        {
            InitializeComponent();

            this.ac_level = level;
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            new Groups(this.ac_level).Show();
        }

        private void SubjectClasses_Click(object sender, EventArgs e)
        {
            new SubjectClassess().ShowDialog();
        }

        private void SubjectTeachers_Click(object sender, EventArgs e)
        {
            new TeachersSubjects(this.ac_level).ShowDialog();
        }
    }
}
