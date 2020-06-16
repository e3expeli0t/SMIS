using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMISInternal
{
    class Field
    {
        public static bool Valid(String value)
        {
            return !String.IsNullOrEmpty(value);
        }

        public static bool Valid(params String[] values)
        {
            bool valid = true;

            foreach (string value in values)
            {
                valid = valid && Valid(value);
            }

            return valid;
        }

        public static bool IsNumber(params String[] values)
        {
            bool valid = true;

            foreach (String value in values)
            {
                int _;
                valid = valid && int.TryParse(value, out _);
            }

            return valid;
        }
    }
}
