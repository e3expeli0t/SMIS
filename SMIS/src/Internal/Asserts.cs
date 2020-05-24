using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMISInternal
{
    class Asserts
    {
        public static void ASSERT_NOT_REACHED(string name = "GLOBAL") {
            ASSERT(false, name + "Assert not reached");
        }


        public static void ASSERT(Boolean cond, String info = "GLOBAL: Asseration failed") {
            if (!cond) {
                Panic(info);
            }
        }

        public static void Panic(String info) {
            throw new Exception(info);
        }
    }
}
