using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * todo: add mutate function. to allow externals classes change the
 * value of external row
 */
namespace SMIS.DBControl
{

    interface DBElement <T, R>
    {
        bool exist(T elem);
        R lookup(T elem);
    }
}

