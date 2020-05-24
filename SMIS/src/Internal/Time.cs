using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMISInternal
{

    /*
     * Time grammer:
     *      time_list ::= "$" [time_list] "$" | time
     *      time      ::=  hour:min:sec
     *      where hour min and sec are lexemes
      */

    class Time
    {
        public static List<String> extractTime(String time) {
            List<String> times = new List<string>();

            if(!Field.Valid(time)) {
                return null;
            }

            times = time.Split('$').ToList<String>();
            return times;
        }

        public static String generateTime(List<String> times) {
            String hrs = "$";

            foreach (String time in times)
            {
                hrs += time + "$";
            }

            return hrs;
        }
    }
}
