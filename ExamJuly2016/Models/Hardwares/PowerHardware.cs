using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Utils.Enumerations;

namespace OOPBasicsExam.Models.Hardware
{
    public class PowerHardware : AbstractHardware
    {
        private const double PowerHardwareCapacityPercent = -0.75;
        private const double PowerHardwareMemoryPercent = 0.75;

        public PowerHardware(string name, int capacity, int memory)
            : base(name, capacity, memory, HardwareTypes.Power,PowerHardwareCapacityPercent,PowerHardwareMemoryPercent)
        {
        }
    }
}
