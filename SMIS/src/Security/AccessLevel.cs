using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMISSecurity
{
    public enum AccessLevel
    {
        Admin = 0x0,
        AdminUser = 0x1,
        RegularUser = 0x2,
        Default = 0x2,
    }

    public class LevelAsserts {

        public static void ASSERT_ADMIN_ACCESS(AccessLevel level) {
            VALID_ACCSES(level, AccessLevel.Admin);
        }
        
        public static void VALID_ACCSES(AccessLevel level, AccessLevel min = AccessLevel.Default)
        {
            if (level != min)
            {
                //FIXME: caller must handle this exception
                throw new UnauthorisedUserExecption("Invalid accsess to teachers dataset");
            }
        }
    }
}
