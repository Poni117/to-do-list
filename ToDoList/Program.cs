using System;
using ToDoList.Services;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandsService commands = new CommandsService();
            DataService data = new DataService();
            while(true)
            {
                Console.WriteLine("Enter Commands (show  / add / delete)");
                string userAnswer = Console.ReadLine();
                if(userAnswer == "show")
                {
                    commands.ShowTasks(data);
                }
                else if (userAnswer == "add")
                {
                    commands.AddTask(data);
                }

                else if(userAnswer == "delete")
                {
                    commands.RemoveTask(data);
                }
               
                else if (userAnswer == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{userAnswer} is not exist");
                }
            }
        }
    }
}
