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
            Commands commands = new Commands();
            DataService data = new DataService();
            while(true)
            {

                Console.WriteLine("Enter Commands (show list / set list)");
                string userAnswer = Console.ReadLine();
                if(userAnswer == "show list")
                {
                    commands.ShowList(tasks, data);
                }
                else if (userAnswer == "set list")
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
