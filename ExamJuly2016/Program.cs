using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Core;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Utils.ConsoleReader;
using OOPBasicsExam.Utils.Writers;

namespace OOPBasicsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommandDispatcher commandDispatcher = new CommandDispatcher();
            IInputReader reader = new ConsoleReader();
            IOutputWriter writer = new ConsoleWriter();
            commandDispatcher.Writer = writer;
            IEngine engine = new Engine(commandDispatcher,reader,writer);
            commandDispatcher.Stop = engine;
            engine.Run();
        }
    }
}
