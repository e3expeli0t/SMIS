﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SMISSecurity;
using SMISInternal;

using SMIS.DataBase;


namespace SMIS
{
    public partial class Teachers : Form
    {
        private List<String> hours = new List<String>();

        private String hlist = null;
        private bool EditMode = false;

        private const int FIRST_NAME = 1;
        private const int LAST_NAME = 2;
        private const int PHONE = 3;
        private const int ADDRESS = 5;
        private const int HOURES = 6;


        public Teachers(AccessLevel level)
        {
            LevelAsserts.ASSERT_ADMIN_ACCESS(level);
            InitializeComponent();

            
        }


        //need to check if the view filled successfully
        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smisDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.smisDataSet.Teachers);
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

        //---------------------------------------------------------------------------------------------------
        // Button evenets functions


        private void DoSave_Click(object sender, EventArgs e)
        {
            if (this.smisDataSet.HasChanges())
            {
                this.smisDataSet.AcceptChanges();
            }

            if (!Field.Valid(this.TeacherName.Text, this.PhoneNumber.Text, this.addr.Text))
            {
                Errors.DisplayMinor("One or more input fields are empty");
                return;
            }

            if (!Field.IsNumber(this.PhoneNumber.Text, this.TotalTime.Text, this.IDNum.Text)) {
                Errors.DisplayMinor("phone number' total time and id should be numbers");
                return;
            }

            Dictionary<string, string> namesDict = this.parseName();

            if (namesDict == null)
            {
                return;
            }

            this.smisDataSet.Teachers.AddTeachersRow(this.IDNum.Text, namesDict["first_name"], namesDict["last_name"], this.PhoneNumber.Text,
                (int)AccessLevel.Default, this.addr.Text, this.TotalTime.Text);

            this.teachersTableAdapter.Update(this.smisDataSet.Teachers);
           
            TecherTime setTime = new TecherTime(this.IDNum.Text);
            setTime.ShowDialog();
        }

        private void TeachersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditMode = true;
            this.DoEdit.Visible = true;
            this.DoCancel.Visible = true;
            this.fillFromRow();
        }

        private void DoDelete_Click(object sender, EventArgs e)
        {
            if (this.TeachersView.CurrentRow.Index > this.TeachersView.RowCount)
            {
                Errors.DisplayMinor("There is no data to remove");
                return;
            }

            this.smisDataSet.Teachers[this.TeachersView.CurrentRow.Index].Delete();
            this.teachersTableAdapter.Update(this.smisDataSet.Teachers);
        }

        private void DoEdit_Click(object sender, EventArgs e)
        {
            cancelEdit();
            Dictionary<string, string> names = this.parseName();

            if (names == null)
            {
                return;
            }

            this.EditRow(names["first_name"], names["last_name"], this.PhoneNumber.Text, this.addr.Text);
            return;
        }

        private void DoCancel_Click(object sender, EventArgs e)
        {
            this.cancelEdit();
        }

        //--------------------------------------------------------------------------------------------------------------------
        //Helpers


        private void cancelEdit()
        {
            this.EditMode = false;
            this.DoEdit.Visible = false;
            this.DoCancel.Visible = false;
        }

        private bool EditRow(String fname, String lname, String phone, String addrs)
        {
            int index = this.TeachersView.CurrentRow.Index;
            try
            {
                this.smisDataSet.Teachers.Rows[index][FIRST_NAME] = fname;
                this.smisDataSet.Teachers.Rows[index][LAST_NAME] = lname;
                this.smisDataSet.Teachers.Rows[index][PHONE] = phone;
                this.smisDataSet.Teachers.Rows[index][ADDRESS] = addrs;
                this.smisDataSet.Teachers.Rows[index][HOURES] = Time.generateTime(this.hours);
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
            try
            {
                int index = this.TeachersView.CurrentRow.Index;
                this.TeacherName.Text = this.smisDataSet.Teachers.Rows[index][FIRST_NAME].ToString() +
                    " " + this.smisDataSet.Teachers.Rows[index][LAST_NAME].ToString();
                this.PhoneNumber.Text = this.smisDataSet.Teachers.Rows[index][PHONE].ToString();
                this.addr.Text = this.smisDataSet.Teachers.Rows[index][ADDRESS].ToString();


                this.hlist = this.smisDataSet.Teachers.Rows[index][HOURES].ToString();
            }
            catch (IndexOutOfRangeException e)
            {
                Errors.HandleException(e);
                return;
            }
        }
    }
}
