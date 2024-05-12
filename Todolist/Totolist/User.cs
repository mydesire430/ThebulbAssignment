using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totolist
{
    public class User
    {
        // Field
        int id;
        string name;
        // Property
        public int Id{get; set;} 
        public string Name{ get; set;}
        // Constructor
        public User(int id, string name)
        {
            id = Id;
            name = Name;

        }
    }
}
