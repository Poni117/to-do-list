using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class DoList
    {
        private string _name;
        private string[] _tasks;

        public DoList(string name)
        {
            _name = name;

        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public string[] GetTasks()
        {
            return _tasks;
        }
        public void SetTasks(string[] tasks)
        {
            _tasks = tasks;
        }

        public string[] ProgramTasks()
        {
            
            string tasks = null;
            
            while (true)
            {
                int a = 0;
                bool isPointExist = false;
                bool isCommaExist = false;
                string tasksName = Console.ReadLine();
                for(int i = 0; i < tasksName.Length; i++)
                {
                    switch (tasksName[i])
                    {
                        case ',':
                        {
                            isCommaExist = true;
                            break;
                        }
                        case '.':
                        {
                            isPointExist = true;
                            break;
                        }
                    }
                }
                string[] arrayTasks = new string[9];
                for (; a < arrayTasks.Length;)
                {

                    if (isCommaExist == true)
                    {
                        arrayTasks[a] = tasks + tasksName;
                    }
                    if (isCommaExist = false || isPointExist == false)
                    {
                        arrayTasks[a] = tasks + tasksName + ',';
                    }
                    else if (isPointExist == true)
                    {
                        arrayTasks[a] = tasks + tasksName;
                        break;
                    }
                    a++;
                    Console.WriteLine(arrayTasks[a]);
                }
                    return arrayTasks;
                
            }
            
        }
        
    }
}
