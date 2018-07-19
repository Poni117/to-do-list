using System;

namespace ToDoList
{
    class Commands
    {
        public void ShowList(List<Task> tasks, DataService data)
        {
            tasks = data.Load();

            for (int i = 0; i < tasks.GetLength(); i++)
            {
                Console.WriteLine($"{ tasks.GetItem(i).GetDescription()}");
            }
        }

        public void SetList(List<Task> tasks, DataService data)
        {
            int numberOfTasks = 0;
            while (true)
            {
                Console.WriteLine("Введите задачу");
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
    }
}
