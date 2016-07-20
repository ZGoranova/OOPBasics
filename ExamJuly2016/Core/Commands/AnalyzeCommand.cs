using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;

namespace OOPBasicsExam.Core.Commands
{
    public class AnalyzeCommand : AbstractCommand
    {
        private IOutputWriter writer;

        public AnalyzeCommand(IOutputWriter writer)
            : base()
        {
            this.writer = writer;
        }

        public override void Execute(params string[] parameters)
        {
            int countOfHardwareComponents = this.Hardweres.GetAll().Count();
            int countOfSoftwareComponents = 0;
            foreach (var hardwre in this.Hardweres.GetAll())
            {
                countOfSoftwareComponents += hardwre.Softwares.Count();
            }

            int maximumMemory = this.Hardweres.GetMaxMemory();
            int maximumCapacity = this.Hardweres.GetMaxCapacity();
            int usedMemory = this.Hardweres.GetUseMemory();
            int usedCapacity = this.Hardweres.GetUseCapacity();
            StringBuilder result = new StringBuilder();
            result.AppendLine("System Analysis");
            result.AppendLine(string.Format("Hardware Components: {0}", countOfHardwareComponents));
            result.AppendLine(string.Format("Software Components: {0}", countOfSoftwareComponents));
            result.AppendLine(string.Format("Total Operational Memory: {0} | {1}", usedMemory, maximumMemory));
            result.Append(string.Format("Total Capacity Taken: {0} | {1}", usedCapacity, maximumCapacity));
            this.writer.WriteLine(result.ToString());
        }
    }
}
