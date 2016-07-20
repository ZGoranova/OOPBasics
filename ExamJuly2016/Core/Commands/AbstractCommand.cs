using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;

namespace OOPBasicsExam.Core.Commands
{
    public abstract class AbstractCommand : ICommand
    {
        public IRepository<IHardware> Hardweres { get; set; }

        public abstract void Execute(params string[] parameters);
    }
}
