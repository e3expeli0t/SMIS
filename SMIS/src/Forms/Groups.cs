using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMIS
{
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.smisDataSet.Groups);

        }
    }
}
