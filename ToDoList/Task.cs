using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Task<T, U>
    {
        private T _id;
        private U _action;

        public Task(T id, U action)
        {
            _id = id;
            _action = action;
        }

        public T GetId()
        {
            return _id;
        }
        public U GetAction()
        {
            return _action;
        }
    }
}
