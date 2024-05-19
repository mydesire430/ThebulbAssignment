using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.SO
{
    public class Contact
    {
        //property
        string Name { get;  set; }
        string PhoneNumber { get;  set; }
        public Contact(string name, string phoneNumber)
        { 
        Name = name;
        PhoneNumber = phoneNumber;
        }

    }
}
