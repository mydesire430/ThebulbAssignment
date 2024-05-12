using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totolist
{
    public class Task
    {
        //Field
        string name;
        string description;
        DateTime dueDate;
        bool completed;
        //property
        public string Name { get; set; }
        public string Description { get; set;}
        public DateTime DueDate { get; set;}
        public bool Completed { get; set;}
        // Constructor
        public Task(string name, string description, DateTime dueDate)
        {
            name = Name;
            description = Description;
            dueDate = dueDate;
            completed = false;
        }
        }

    }

