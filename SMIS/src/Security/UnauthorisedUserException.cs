using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMISSecurity
{
    class UnauthorisedUserExecption : Exception
    {
        public UnauthorisedUserExecption()
        {
        }

        public UnauthorisedUserExecption(String msg)
            : base(msg)
        {
        }

        public UnauthorisedUserExecption(String msg, Exception inner)
            : base(msg, inner)
        {
        }
    }
}
