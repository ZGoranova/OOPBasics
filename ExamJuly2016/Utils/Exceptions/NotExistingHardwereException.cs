using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicsExam.Utils.Exceptions
{
    public class NotExistingHardwereException : AbstractException
    {
        public NotExistingHardwereException(string msg)
            : base(msg)
        {
        }
    }
}
