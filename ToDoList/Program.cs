using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Commands commands = new Commands();
            DataService data = new DataService();
            while(true)
            {
                Console.WriteLine("Enter Commands (show  / Add / Delete)");
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
