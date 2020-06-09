using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SMIS.Schedualer;
using SMISInternal;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace SMIS.DataBase
{
    class Loader
    {
        private SmisDataSet smisDataSet;
        private OleDbConnection connection;
        private OleDbDataAdapter tableAdapter;

        private String conStr;

        public Loader(SmisDataSet dataSet) {
            this.conStr = Properties.Settings.Default.SmisDBConnectionString;
            this.connection = new OleDbConnection(this.conStr);
            this.connection.Open();

            this.tableAdapter = new SmisDataSetTableAdapters()
            this.smisDataSet = new SmisDataSet();


        }

        public void Reset() {
            this.smisDataSet.Reset();
        }

        // todo: Add times to teacher object
        public Teacher[] GetTeachers() 
        {
            int FIRST_NAME = 1;
            int LAST_NAME = 2;

            List<Teacher> teachers = new List<Teacher>();
            foreach ( DataRow dr in this.smisDataSet.Teachers.Rows) {
                teachers.Add(
                         Teacher.Construct(dr[FIRST_NAME].ToString(), dr[LAST_NAME].ToString(), dr[0].ToString())
                    );
            } 

            Asserts.ASSERT(teachers.Any());

            return teachers.ToArray();
        }

        public bool TeacherExistsStrong(String id = "") {
            Asserts.ASSERT(id.Any(), "Can't search for empty id");

            foreach (DataRow dr in this.smisDataSet.Teachers.Rows) {
                if (dr[0].ToString() == id) {
                    return true;
                }
            }

            return false;
        }

        public bool TeacherExistsSoft(String fname, String lname) {
            Asserts.ASSERT(fname.Any() && lname.Any(), "Can't search for empty name");
            int FIRST_NAME = 1;
            int LAST_NAME = 2;


            Debug.WriteLine(fname, lname);

            foreach (DataRow dr in this.smisDataSet.Teachers.Rows)
            {
                if (dr[FIRST_NAME].ToString() == fname.Trim() && dr[LAST_NAME].ToString() == lname.Trim())
                {
                    return true;
                }
            }

            Asserts.ASSERT_NOT_REACHED();

            return false;
        }
    }
}
