using System;

namespace ToDoList
{
    class Commands
    {
        public void ShowList(List<Task<int, string>> tasks, DataService data)
        {
            tasks = data.Load();

            for (int i = 0; i < tasks.GetLength(); i++)
            {
                Console.WriteLine($"{ tasks.GetItem(i)}");
            }
        }

        public void SetList(List<Task<int, string>> tasks, DataService data)
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
                Task<int, string> task = new Task<int, string>(numberOfTasks, userAction);
                tasks.Add(task);
                numberOfTasks++;
            }

            data.Save(tasks);
        }
    }
}
