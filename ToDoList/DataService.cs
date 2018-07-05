using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ToDoList
{
    class DataService
    {
       private string _path = "Tasks.txt";
       
       public void Save(List<Task> list)
       {
           string txt = "";
           for (int index = 0; index < list.GetLength(); index++)
           {
                Task createTxt = list.GetItem(index);
                txt += $"{createTxt}\n";
           }

           File.WriteAllText(_path, txt);
       }

        public List<Task> Load()
        {
            List<Task> list = new List<Task>();
            string[] readText = File.ReadAllLines(_path);

            for (int i = 0; i < readText.Length; i++)
            {
                
            }
            return list;
        }
    }
}
