using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPBasicsExam.Interfaces;

namespace OOPBasicsExam.Utils.Repositories
{
    public abstract class AbstractRepository<T> : IRepository<T>
    {
        public abstract void Add(T objectT);

        public abstract T GetByName(string name);

        public abstract bool IsThereObject(string name);

        public abstract IEnumerable<T> GetAll();

        public abstract void Remove(T objectT);

        public abstract int GetMaxMemory();

        public abstract int GetMaxCapacity();

        public abstract int GetUseMemory();

        public abstract int GetUseCapacity();
    }
}
