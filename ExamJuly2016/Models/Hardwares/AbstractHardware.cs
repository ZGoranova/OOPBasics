using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Utils.Enumerations;
using OOPBasicsExam.Utils.Exceptions;

namespace OOPBasicsExam.Models.Hardware
{
    public abstract class AbstractHardware :IHardware
    {
        private string name;
        private int maximumCapacity;
        private int maximumMemory;
        private readonly IList<ISoftware> softwares; 
        private readonly double capacityPercent;
        private readonly double memoryPercent;

        protected AbstractHardware(string name, int capacity, int memory, HardwareTypes type,double capPercent, double memoryPercent)
        {
            this.Name = name;
            this.MaximumCapacity = capacity;
            this.MaximumMemory = memory;
            this.Type = type;
            this.capacityPercent = capPercent;
            this.memoryPercent = memoryPercent;
            this.softwares = new List<ISoftware>();
            this.UsedCapacity = 0;
            this.UsedMemory = 0;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!Regex.IsMatch(value, "[a-zA-Z0-9]+"))
                {
                    throw new InvalidParametersException("The name consist of English alphabet letters and digits");
                }

                this.name = value;
            }
        }

        public HardwareTypes Type { get; set; }

        public int MaximumCapacity
        {
            get { return this.maximumCapacity; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidParametersException("The maximum capacity cannot be negative.");
                }

                this.maximumCapacity = value;
            }
        }

        public int MaximumMemory
        {
            get { return this.maximumMemory; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidParametersException("The maximum memory cannot be negative.");
                }

                this.maximumMemory = value;
            }
        }

        public int UsedCapacity { get; set; }

        public int UsedMemory { get; set; }

        public IEnumerable<ISoftware> Softwares
        {
            get { return this.softwares; }
        }

        public void AddSoftwere(ISoftware softwere)
        {
            if (this.UsedCapacity +softwere.CapacityConsumption <= this.MaximumCapacity &&
                this.UsedMemory +softwere.MemoryConsumption <= this.MaximumMemory)
            {
                this.softwares.Add(softwere);
                this.UsedMemory += softwere.MemoryConsumption;
                this.UsedCapacity += softwere.CapacityConsumption;
            } 
        }

        public void RemoveSoftwere(ISoftware softwre)
        {
            if (this.softwares.FirstOrDefault(s => s.Name == softwre.Name) != null)
            {
                this.softwares.Remove(softwre);
                this.UsedMemory -= softwre.MemoryConsumption;
                this.UsedCapacity -= softwre.CapacityConsumption;
            }
        }

        public virtual void Update()
        {
            int capacity = this.MaximumCapacity;
            double newCapacity = capacity * capacityPercent;
            int result = capacity + (int)newCapacity;
            this.MaximumCapacity = result;

            int memory = this.MaximumMemory;
            double newMemory = memory * memoryPercent;
            int resultM = memory + (int)newMemory;
            this.MaximumMemory = resultM;
        }

        private int GetExpressSoftweres()
        {
            int count = 0;

            foreach (var sf in this.softwares)
            {
                if (sf.Type.ToString() == SoftwareTypes.Express.ToString())
                {
                    count++;
                }
            }

            return count;
        }

        private int GetLightSoftweres()
        {
            int count = 0;
            foreach (var sf in this.softwares)
            {
                if (sf.Type.ToString() != SoftwareTypes.Light.ToString())
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Hardware Component – {0}\n", this.Name);
            result.AppendFormat("Express Software Components - {0}\n", GetExpressSoftweres());
            result.AppendFormat("Light Software Components - {0}\n",GetLightSoftweres());
            result.AppendFormat("Memory Usage: {0} / {1}\n", this.UsedMemory, this.MaximumMemory);
            result.AppendFormat("Capacity Usage: {0} / {1}\n", this.UsedCapacity, this.MaximumCapacity);
            result.AppendFormat("Type: {0}\n", this.Type);
            result.AppendFormat(@"Software Components: ");
            int count = 0;
            foreach (var sf in this.softwares)
            {
                if (count < this.softwares.Count - 1)
                {
                    result.AppendFormat("{0}, ", sf);
                }
                else
                {
                    result.AppendFormat("{0} ",sf);
                }
                count++;
            }

            return result.ToString();
        }


    }
}
