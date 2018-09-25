using System;
using ToDoList.DataStructure;
using ToDoList.Domain;

namespace ToDoList.Services
{
    class CommandsService
    {
        public void ShowTasks(DataService data)
        {
            IList<Task> tasks = data.Load();

            for (tasks.InitLoop(); tasks.IsLoopNext() == true;)
            {
                Console.WriteLine($"{tasks.GetItem().GetDescription()}");
            }
        }

        public void AddTask(DataService data)
        {
            IList<Task> tasks = data.Load();

            int numberOfTasks = 0;
            while (true)
            {
                Console.WriteLine("Введите задачу (stop для завершения)");
                string userAction = Console.ReadLine();
                if (userAction == "stop")
                {
                    break;
                }
                Task task = new Task(numberOfTasks, userAction);
                tasks.Add(task);
                numberOfTasks++;
            }

            data.Save(tasks);
        }

       public void RemoveTask(DataService data)
       {
            IList<Task> tasks = data.Load();

            Console.WriteLine("Введите удаляемую задачу");

            string userAnswer = Console.ReadLine();
            int removeId = Convert.ToInt32(userAnswer);

            tasks.Remove(removeId);
            data.Save(tasks);
       }
    }
}
