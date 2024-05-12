using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totolist
{
    public class TodoList
    {
        //Field
        int taskNumber;
        Task  task;

        //property
        public int TaskNumber { get; set; }
            
         
        public Task Task { get; set; } 
        // Constructor
        public TodoList()
        { 
        taskNumber = 0;
        task  = null;

        }
        //Methods
        public void AddTask()
        {
            Console.WriteLine("Enter task name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter task description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter due date (YYYY-MM-DD:");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            task = new Task(name, description, dueDate);
            taskNumber++;

        }
        public void RemoveTask()
        {
            if (task != null)
            {
                Console.WriteLine("Enter task number to remove:");
                int taskToRemove = int.Parse(Console.ReadLine());

                if (taskToRemove == taskNumber)
                {
                    task = null;
                    Console.WriteLine("Task removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("No task available to remove.");
            }
        }

        public void MarkTaskAsCompleted()
        {
            if (task != null)
            {
                Console.WriteLine("Enter task number to mark as completed:");
                int taskToMark = int.Parse(Console.ReadLine());

                if (taskToMark == taskNumber)
                {
                    task.Completed = true;
                    Console.WriteLine("Task marked as completed.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("No task available to mark as completed.");
            }
        }
        public void DisplayTasks()
        {
            if (task != null)
            {
                Console.WriteLine($"Task Name: {task.Name}");
                Console.WriteLine($"Description: {task.Description}");
                Console.WriteLine($"Due Date: {task.DueDate}");
                Console.WriteLine($"Completed : {(task.Completed ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("No tasks available.");
            }
            }
        }
    }

