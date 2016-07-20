using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;
using OOPBasicsExam.Utils.Enumerations;
using OOPBasicsExam.Utils.Exceptions;

namespace OOPBasicsExam.Models.Softwares
{
    public abstract class AbstractSoftware : ISoftware
    {
        private string name;
        private int capacityConsumption;
        private int memoryConsumption;
        private double capacityPercent;
        private double memoryPercent;

        protected AbstractSoftware(string name, int capacity, int memory, SoftwareTypes type, double capacityPercent, double memoryPercent)
        {
            this.Name = name;
            this.CapacityConsumption = capacity;
            this.MemoryConsumption = memory;
            this.Type = type;
            this.capacityPercent = capacityPercent;
            this.memoryPercent = memoryPercent;
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

        public SoftwareTypes Type { get; set; }

        public int CapacityConsumption
        {
            get { return this.capacityConsumption; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidParametersException("The capacity consumption cannot be negative.");
                }

                this.capacityConsumption = value;
            }
        }

        public int MemoryConsumption
        {
            get { return this.memoryConsumption; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidParametersException("The memory consumption cannot be negative.");
                }

                this.memoryConsumption = value;
            }
        }


        public void Update()
        {
            int capacity = this.CapacityConsumption;
            double newCapacity = capacity * capacityPercent;
            int result = capacity + (int)newCapacity;
            this.CapacityConsumption = result;

            int memory = this.MemoryConsumption;
            double newMemory = memory * memoryPercent;
            int resultM = memory + (int)newMemory;
            this.MemoryConsumption = resultM;
        }

        public override string ToString()
        {
            return string.Format(this.Name);
        }
    }
}
