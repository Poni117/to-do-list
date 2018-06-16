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
       List list = new List();
       string path = "Tasks.txt";
       
       public void Save(List list)
       {
           int index = 0;
           string txt = "";
          
           for (; index < list.GetLength();index++)
           {

                string createTxt = list.GetItem(index);
                txt = txt + createTxt + "\n";
                
                
                File.WriteAllText(path, txt);
                    
           }
       }
    }
}
