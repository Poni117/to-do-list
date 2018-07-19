using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            
            Commands commands = new Commands();
            DataService data = new DataService();
            while(true)
            {
                Console.WriteLine("Enter Commands (show list / set list)");
                string userAnswer = Console.ReadLine();
                if(userAnswer == "show")
                {
                    commands.ShowList(tasks, data);
                }
                else if (userAnswer == "add")
                {
                    commands.SetList(tasks, data);
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
