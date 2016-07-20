using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Models.Hardware;

namespace OOPBasicsExam.Core.Commands
{
    public class RegisterPowerHardwareCommand : AbstractCommand
    {
        public override void Execute(params string[] parameters)
        {
            string name = parameters[1];
            int capacity = int.Parse(parameters[2]);
            int memory = int.Parse(parameters[3]);
            IHardware hardwere = new PowerHardware(name,capacity,memory);
            hardwere.Update();
            this.Hardweres.Add(hardwere);
        }
    }
}
