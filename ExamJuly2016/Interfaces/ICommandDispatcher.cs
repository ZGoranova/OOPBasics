using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicsExam.Interfaces
{
    public interface ICommandDispatcher
    {
        IOutputWriter Writer { get; set; }

        IStopable Stop { get; set; }

        IRepository<IHardware> HardwRepository { get; set; } 

        void DispatchCommand(string[] commandArgs);

        void SeedCommands();
    }
}
