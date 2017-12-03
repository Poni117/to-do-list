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
            

            Console.WriteLine("Введите название спика");
            string nameList = Console.ReadLine();
            DoList toDoList = new DoList(nameList);
          

            Console.WriteLine("Введите список задач");

            string[] arrayTasks = toDoList.ProgramTasks();
            
            
           
        }
        
    }
}
