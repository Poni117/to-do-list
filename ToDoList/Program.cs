using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько задач, господин");
            int taskNumber = Int32.Parse(Console.ReadLine());
            Task[] tasks = new Task[taskNumber];

            for (int i = 0; i < taskNumber; i++)
            {
                Console.WriteLine("Введите задачу");
                string userAction = Console.ReadLine();
                tasks[i] = new Task(i, userAction);
            }


           for (int i = 0; i < tasks.Length - 1; i++)
           {
                Console.WriteLine($"{tasks[i].GetId()}. {tasks[i].GetAction()}");
           }
        }

    }
}
