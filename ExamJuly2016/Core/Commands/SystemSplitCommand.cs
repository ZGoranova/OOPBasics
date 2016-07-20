using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Utils.Enumerations;

namespace OOPBasicsExam.Core.Commands
{
    public class SystemSplitCommand : AbstractCommand
    {
        private readonly IOutputWriter writer;
        private readonly IStopable stop;

        public SystemSplitCommand(IOutputWriter writer,IStopable stop)
            : base()
        {
            this.writer = writer;
            this.stop = stop;
        }

        public override void Execute(params string[] parameters)
        {
            StringBuilder result = new StringBuilder();
            IEnumerable<IHardware> sorted = this.Hardweres.GetAll().OrderByDescending(t => t.Type.ToString());
            int count = 0;
            foreach (var s in sorted)
            {
                if (count < sorted.Count() - 1)
                {
                    result.AppendLine(string.Format(s.ToString()));
                }
                else
                {
                    result.Append(s.ToString());
                }
                count++;
            }

            this.writer.WriteLine(result.ToString());
            this.stop.Stop();
        }
    }
}
