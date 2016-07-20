using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicsExam.Interfaces
{
    public interface ICommand : IExecutable
    {
        IRepository<IHardware> Hardweres { get; set; } 
    }
}
