using System;

namespace Totolist
{
    public class Program
    {
        static void Main(string[] args)
        {
            TodoList todoList = new TodoList();
            while (true)
            {
                Console.WriteLine("1. Add Task ");
                Console.WriteLine("2. Remove Task ");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Display Tasks");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        todoList.AddTask();
                        break;
                    case 2: 
                        todoList.RemoveTask(); 
                        break;  
                    case 3: 
                        todoList.MarkTaskAsCompleted();
                    break;
                    case 4:
                    todoList.DisplayTasks();
                    break;
                    case 5:
                        return;
                        default: 
                 Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}
