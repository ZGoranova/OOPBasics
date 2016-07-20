using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Utils.Exceptions;

namespace OOPBasicsExam.Utils.Repositories
{
    public class HardwareRepositoty : AbstractRepository<IHardware>
    {
        public static readonly HardwareRepositoty Instance = new HardwareRepositoty();

        private readonly Dictionary<string, IHardware> hardwares;

        private HardwareRepositoty()
        {
            this.hardwares = new Dictionary<string, IHardware>();
        }

        public override void Add(IHardware objectT)
        {
            this.hardwares.Add(objectT.Name,objectT);
        }

        public override IHardware GetByName(string name)
        {
            if (this.hardwares.ContainsKey(name))
            {
                return this.hardwares[name];
            }
            else
            {
                throw new NotExistingHardwereException("There isn't softwere with this name");
            }
            
        }

        public override bool IsThereObject(string name)
        {
            if (this.hardwares.ContainsKey(name))
            {
                return true;
            }

            return false;
        }

        public override IEnumerable<IHardware> GetAll()
        {
            return this.hardwares.Values;
        }

        public override void Remove(IHardware objectT)
        {
            if (IsThereObject(objectT.Name))
            {
                this.hardwares.Remove(objectT.Name);
            }
        }

        public override int GetMaxMemory()
        {
            int memory = 0;
            foreach (var hd in this.hardwares.Values)
            {
                memory += hd.MaximumMemory;
            }

            return memory;
        }

        public override int GetMaxCapacity()
        {
            int capacity = 0;
            foreach (var hd in this.hardwares.Values)
            {
                capacity += hd.MaximumCapacity;
            }

            return capacity;
        }

        public override int GetUseMemory()
        {
            int memory = 0;
            foreach (var hd in this.hardwares.Values)
            {
                memory += hd.UsedMemory;
            }

            return memory;
        }

        public override int GetUseCapacity()
        {
            int capacity = 0;
            foreach (var hd in this.hardwares.Values)
            {
                capacity += hd.UsedCapacity;
            }

            return capacity;
        }
    }
}
