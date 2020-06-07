using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SMIS.Schedualer;

namespace SMIS.DataBase
{
    class Loader
    {
        private SmisDataSet smisDataSet;

        public Loader(SmisDataSet dataSet) {
            this.smisDataSet = dataSet;
        }

        public void Reset() {
            this.smisDataSet.Reset();
        }

        public Teacher[] GetTeachers() 
        {
            int FIRST_NAME = 1;
            int LAST_NAME = 2;
            int PHONE = 3;
            int ADDRESS = 5;
            int HOURES = 6;
            
            String first_name;
            String last_name;
            String times;
            List<Teacher> teachers = new List<Teacher>();
            while (true) {
                teachers.Add(Teacher.Construct(
            } 
        }
    }
}
