using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMISInternal
{
    class Time
    {
        public static List<String> extractTime(String time) {
            List<String> times = new List<string>();

            if(!Field.Valid(time)) {
                return null;
            }

            String[] stime = time.Split('$');

            Errors.DisplayMinor(stime.ToString());

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
