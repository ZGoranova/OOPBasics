using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Models.Softwares;
using OOPBasicsExam.Utils.Exceptions;

namespace OOPBasicsExam.Core.Commands
{
    class RegisterExpressSoftwareCommand : AbstractCommand
    {
        public override void Execute(params string[] parameters)
        {
            string hardwareName = parameters[1];
            string name = parameters[2];
            int capacity = int.Parse(parameters[3]);
            int memory = int.Parse(parameters[4]);
            ISoftware softwere = new ExpressSoftware(name, capacity, memory);
            softwere.Update();
            try
            {
                IHardware hardwere = this.Hardweres.GetByName(hardwareName);
                hardwere.AddSoftwere(softwere);
            }
            catch (NotExistingHardwereException)
            {
                //Do Nothing
            }
        }
    }
}
