using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;

namespace OOPBasicsExam.Utils.Repositories
{
    public class DumpHardwreRepository : AbstractRepository<IHardware>
    {
        private static readonly IRepository<IHardware> Instance = new DumpHardwreRepository();

        private readonly Dictionary<string, IHardware> dumpHardwares;

        public DumpHardwreRepository()
        {
            this.dumpHardwares = new Dictionary<string, IHardware>();
        }

        public override void Add(IHardware objectT)
        {
            throw new NotImplementedException();
        }

        public override IHardware GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public override bool IsThereObject(string name)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<IHardware> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Remove(IHardware objectT)
        {
            throw new NotImplementedException();
        }

        public override int GetMaxMemory()
        {
            throw new NotImplementedException();
        }

        public override int GetMaxCapacity()
        {
            throw new NotImplementedException();
        }

        public override int GetUseMemory()
        {
            throw new NotImplementedException();
        }

        public override int GetUseCapacity()
        {
            throw new NotImplementedException();
        }
    }
}
