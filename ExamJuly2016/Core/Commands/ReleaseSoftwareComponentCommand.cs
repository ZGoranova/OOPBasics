using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Utils.Exceptions;

namespace OOPBasicsExam.Core.Commands
{
    public class ReleaseSoftwareComponentCommand : AbstractCommand
    {
        public override void Execute(params string[] parameters)
        {
            string hardwereName = parameters[1];
            string softwereName = parameters[2];
            try
            {
                IHardware hardwere = this.Hardweres.GetByName(hardwereName);
                if (hardwere.Softwares.FirstOrDefault(s => s.Name == softwereName) != null)
                {
                    ISoftware soft = hardwere.Softwares.FirstOrDefault(s => s.Name == softwereName);
                    hardwere.RemoveSoftwere(soft);
                }
            }
            catch (NotExistingHardwereException)
            {
                //
            }
        }
    }
}
