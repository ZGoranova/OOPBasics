using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Utils.Enumerations;

namespace OOPBasicsExam.Models.Hardware
{
    public class HeavyHardware : AbstractHardware
    {
        private const double HeavyHardwareCapacityPercent = 1.0;
        private const double HeavyHardwareMemoryPercent =-0.25;

        public HeavyHardware(string name, int capacity, int memory)
            : base(name, capacity, memory, HardwareTypes.Heavy,HeavyHardwareCapacityPercent,HeavyHardwareMemoryPercent)
        {
        }
    }
}
