using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Utils.Enumerations;

namespace OOPBasicsExam.Interfaces
{
    public interface IHardware
    {
        string Name { get; set; }

        HardwareTypes Type { get; set; }

        int MaximumCapacity { get; set; }

        int MaximumMemory { get; set; }

        int UsedCapacity { get; set; }

        int UsedMemory { get; set; }

        IEnumerable<ISoftware> Softwares { get; }

        void AddSoftwere(ISoftware softwere);

        void RemoveSoftwere(ISoftware softwre);

        void Update();
    }
}
