using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMIS.DataBase
{
    interface DBTable<T>
    {
        T Search(T value);
        bool Exists(T value);
        T[] GetRow(uint row_number);
    }
}
