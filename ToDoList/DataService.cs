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
                Task task = list.GetItem(index);
                txt += $"{task.GetDescription()}\n";
           }

           File.WriteAllText(_path, txt);
       }

        public List<Task> Load()
        {
            List<Task> list = new List<Task>();
            string[] descriptions = File.ReadAllLines(_path);

            for (int i = 0; i < descriptions.Length; i++)
            {
                Task task = new Task(i, descriptions[i]);
                list.Add(task);
            }
            return list;
        }
    }
}
