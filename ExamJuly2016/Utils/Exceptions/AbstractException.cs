using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicsExam.Utils.Exceptions
{
    public abstract class AbstractException : Exception
    {
        protected AbstractException(string msg)
            : base(msg)
        {
        }
    }
}
