﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;

using SMISInternal;
using SMIS.SmisDataSetTableAdapters;

namespace SMIS.DataBase
{
    class TeachersDBTable : DBTable<DataRow> {
        private const int FIRST_NAME = 1;
        private const int LAST_NAME = 2;
        private const int PHONE = 3;
        private const int ADDRESS = 5;
        private const int HOURES = 6;


        private SmisDataSet ds = new SmisDataSet();
        private TeachersTableAdapter TeachersTA = new TeachersTableAdapter();

        public TeachersDBTable()
        {
            ds.DataSetName = "SmisDataSet";
            ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;

            this.TeachersTA.Fill(this.ds.Teachers);

            if (ds.HasChanges())
            {
                ds.GetChanges();
            }

            ds.AcceptChanges();

            if (ds.Teachers.Rows.Count == 0)
            {
                Errors.DisplayMinor("Couldn't load teachers Table");
            }

        }

        public bool Exists(string name)
        {
            foreach (DataRow row in ds.Teachers.Rows) {
                String full_name = row[FIRST_NAME].ToString()+" "+row[LAST_NAME].ToString();
                if (row[FIRST_NAME].ToString() == name || row[LAST_NAME].ToString() == name || full_name == name) {
                    return true;
                }
            }
 
            return true;
        }

        public DataRow Search(DataRow s) {
            throw new Exception("Not implemanted");
        }

        DataRow DBTable<DataRow>.Search(DataRow value)
        {
            throw new NotImplementedException();
        }

        bool DBTable<DataRow>.Exists(DataRow value)
        {
            throw new NotImplementedException();
        }

        DataRow[] DBTable<DataRow>.GetRow(uint row_number)
        {
            throw new NotImplementedException();
        }
    }

}
