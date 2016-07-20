using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;

namespace OOPBasicsExam.Utils.ConsoleReader
{
    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            string line = Console.ReadLine();
            return line;
        }
    }
}
