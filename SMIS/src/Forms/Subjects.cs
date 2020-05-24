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
        public Subjects(AccessLevel level)
        {

            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.smisDataSet.Subjects);

        }

    }
}
