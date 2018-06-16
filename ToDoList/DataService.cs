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
       
       public void Save(List list)
       {
           string txt = "";
           for (int index = 0; index < list.GetLength(); index++)
           {
                string createTxt = list.GetItem(index);
                txt += $"{createTxt}\n";
           }

           File.WriteAllText(_path, txt);
       }

        public List Load()
        {
            List list = new List();
            string[] readText = File.ReadAllLines(_path);

            for (int i = 0; i < readText.Length; i++)
            {
                list.Add(readText[i]);
            }
            return list;
        }
    }
}
