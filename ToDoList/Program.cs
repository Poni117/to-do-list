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
            List tasks = new List();
            
            while (true)
            {
                Console.WriteLine("Введите задачу");
                string userAction = Console.ReadLine();
                if(userAction == "stop")
                {
                    break;
                }
                tasks.Add(userAction);
            }
            
            for (int i = 0; i < tasks.GetLength(); i++)
            {
                Console.WriteLine($"{i + 1}. {tasks.GetItem(i)}");
            }
        }

    }
}
