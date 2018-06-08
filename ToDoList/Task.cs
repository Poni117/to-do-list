using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Task
    {
        private int _id;
        private string _action;

        public Task(int id, string action)
        {
            _id = id;
            _action = action;
        }

        public int GetId()
        {
            return _id;
        }
        public string GetAction()
        {
            return _action;
        }
    }
}
