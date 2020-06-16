using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SMIS.Schedualer;
using SMIS.DataBase;
using SMISSecurity;
namespace SMIS
{
    public partial class Groups : Form
    {
        private Dictionary<String, String> id_map = new Dictionary<String, String>();
        private Dictionary<String, String> class_map = new Dictionary<String, String>();

        public Groups(AccessLevel level)
        {
            LevelAsserts.ASSERT_ADMIN_ACCESS(level);
            Cursor.Current = Cursors.WaitCursor;

            InitializeComponent();

            // Fill all the ComboBoxes

            Teacher[] teachers = ScheduleInit.GetTeachers();
            Dictionary<String, Teacher> name_map = new Dictionary<string, Teacher>();

            //Note: there is big problem since in the classes form we are using
            // Name as teacher refrence( should be resolved to id)
            foreach (Teacher t in teachers)
            {
                this.id_map.Add(t.FirstName + " " + t.LastName, t.Id);
                this.TeacherSelector.Items.Add(t.FirstName + " " + t.LastName);
                name_map.Add(t.FirstName + " " + t.LastName, t);
            }

            Class[] classes = ScheduleInit.GetClasses(name_map);

            foreach (Class c in classes)
            {
                this.class_map.Add(c.Name, c.Teacher.FirstName + " " + c.Teacher.LastName);
                this.ClassSelector.Items.Add(c.Name);
            }

            Cursor.Current = Cursors.Default;
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.smisDataSet.Groups);

        }

        private void ClassSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TeacherSelector.Text = this.class_map[this.ClassSelector.Text];
        }
    }
}
