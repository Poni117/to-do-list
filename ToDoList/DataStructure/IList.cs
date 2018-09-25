using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DataStructure
{
    interface IList<T>
    {
        void Add(T value);
        int GetLength();
        T GetItem();
        void InitLoop();
        bool IsLoopNext();
        void Remove(int index);
    }
}
