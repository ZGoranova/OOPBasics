using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Utils.Enumerations;

namespace OOPBasicsExam.Interfaces
{
    public interface ISoftware
    {
        string Name { get; set; }

        SoftwareTypes Type { get; set; }

        int CapacityConsumption { get; set; }

        int MemoryConsumption { get; set; }

        void Update();
    }
}
