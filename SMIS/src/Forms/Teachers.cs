using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMIS.DBControl;
using SMISSecurity;
using SMISInternal;


namespace SMIS
{
    public partial class Teachers : Form
    {
        private List<String> hours = new List<string>();

        public Teachers(AccessLevel level)
        {
            if (level != AccessLevel.Admin)
            {
                //FIXME: caller must handle this exception
                throw new UnauthorisedUserExecption("Invalid accsess to teachers dataset");
            }
            InitializeComponent();
        }


        //need to check if the view filled successfully
        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SmisDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.SmisDataSet.Teachers);
        }

        public static  bool exist(string elem)
        {
            //throw new NotImplementedException();
            return true;
        }

        public static object lookup(string elem)
        {
            throw new NotImplementedException();
        }

        private void AddHour_Click(object sender, EventArgs e)
        {
            this.hours.Add(this.TimePicker.Text);
        }

        private void DoSave_Click(object sender, EventArgs e)
        {
            if (!Field.Valid(this.TeacherName.Text, this.PhoneNumber.Text, this.Address.Text)) {
                Errors.DisplayMinor("One or more input fields are empty");
                return;
            }

            String[] names = this.TeacherName.Text.Split(' ', '\t');
            if (names.Length < 2) {
                Errors.DisplayMinor("Please supply full name.");
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

                firstName = firstName.Take(firstName.Length - 1).ToString();
            }


            if (!this.hours.Any()) {
                Errors.DisplayMinor("Please choose teacher time");
                return;
            }

            String hrs = this.hours.First();

            foreach (String hour in this.hours) {
                hrs += "$" + hrs;
            }

            String id = RandomString.Generate();

            //todo: Change hrs to string
            this.SmisDataSet.Teachers.AddTeachersRow(id, firstName, lastName, this.PhoneNumber.Text, 
                (int) AccessLevel.Default, this.Address.Text, 123344);
        }

    }
}
