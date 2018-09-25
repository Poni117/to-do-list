using System;
using System.IO;

using ToDoList.Domain;
using ToDoList.DataStructure;

namespace ToDoList.Services
{
    class DataService
    {
       private string _path = "Tasks.txt";
       
       public void Save(IList<Task> list)
       {
           string txt = "";
           
           for (list.InitLoop(); list.IsLoopNext() == true;)
           {
                Task task = list.GetItem();
                txt += $"{task.GetDescription()}\n";
           }

           File.WriteAllText(_path, txt);
       }

        public IList<Task> Load()
        {
            if (!File.Exists(_path))
            {
                return new LinkedList<Task>();
            }


            string[] descriptions = File.ReadAllLines(_path);

            IList<Task> list = new LinkedList<Task>();
            for (int i = 0; i < descriptions.Length; i++)
            {
                Task task = new Task(i, descriptions[i]);
                list.Add(task);
            }

            return list;
        }
    }
}
