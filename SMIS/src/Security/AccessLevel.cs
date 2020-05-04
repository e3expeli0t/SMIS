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
    }
}
