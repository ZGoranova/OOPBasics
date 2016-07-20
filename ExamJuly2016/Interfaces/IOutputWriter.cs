using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicsExam.Interfaces
{
    public interface IOutputWriter
    {
        void Write(string text);

        void WriteLine(string text);
    }
}
