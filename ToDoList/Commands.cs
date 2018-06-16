using System;

namespace ToDoList
{
    class Commands
    {
        public void ShowList(List tasks, DataService data)
        {
            tasks = data.Load();

            for (int i = 0; i < tasks.GetLength(); i++)
            {
                Console.WriteLine($"{ tasks.GetItem(i)}");
            }
        }

        public void SetList(List tasks, DataService data)
        {
            while (true)
            {
                Console.WriteLine("Введите задачу");
                string userAction = Console.ReadLine();
                if (userAction == "stop")
                {
                    break;
                }
                tasks.Add(userAction);
            }

            data.Save(tasks);
        }
    }
}
