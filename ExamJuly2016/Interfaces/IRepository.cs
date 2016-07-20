using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicsExam.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T objectT);

        T GetByName(string name);

        bool IsThereObject(string name);

        IEnumerable<T> GetAll();

        void Remove(T objectT);

        int GetMaxMemory();

        int GetMaxCapacity();

        int GetUseMemory();

        int GetUseCapacity();
    }
}
