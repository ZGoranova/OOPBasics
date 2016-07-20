using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Utils.Enumerations;

namespace OOPBasicsExam.Models.Softwares
{
    public class ExpressSoftware : AbstractSoftware
    {
        private const double ExpressSoftwareCapacityPercent = 0;
        private const double ExpressSoftwereMemoryPercent = 1.0;

        public ExpressSoftware(string name, int capacity, int memory) 
            : base(name, capacity, memory,SoftwareTypes.Express, ExpressSoftwareCapacityPercent, ExpressSoftwereMemoryPercent)
        {
        }
    }
}
