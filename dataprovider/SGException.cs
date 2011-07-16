using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class ScriptGenException : ApplicationException
    {
        public ScriptGenException()
            : base()
        {
        }
        public ScriptGenException(string msg)
            : base(msg)
        {
        }
    }
}
