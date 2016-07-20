using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Utils.Enumerations;

namespace OOPBasicsExam.Models.Softwares
{
    public class LightSoftware : AbstractSoftware
    {
        private const double LightSoftwareCapacityPercent = 0.5;
        private const double LightSoftwereMemoryPercent = -0.5;

        public LightSoftware(string name, int capacity, int memory) 
            : base(name, capacity, memory,SoftwareTypes.Express, LightSoftwareCapacityPercent,LightSoftwereMemoryPercent)
        {
        }
    }
}
