using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain
{
    class Task
    {
        private int _id;
        private string _description;

        public Task(int id, string description)
        {
            _id = id;
            _description = description;
        }

        public int GetId()
        {
            return _id;
        }
        public string GetDescription()
        {
            return _description;
        }
    }
}
