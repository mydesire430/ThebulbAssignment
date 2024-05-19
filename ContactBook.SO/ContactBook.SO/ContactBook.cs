using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactBook.SO
{
    internal class ContactBook
    {
        private Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
        public void AddContact(string name, string phoneNumber)
        {
            contacts[name] = new Contact { Name = name, PhoneNumber = phoneNumber };
            Console.WriteLine("Contact added successfully.");
        }
        public void RemoveContact(string name)
        {
            if (contacts.ContainsKey(name))
            {
                contacts.Remove(name);
                Console.WriteLine($"Contact {name} has been removed.");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        public void FindContact(string name)
        {
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact {name}'s phone number: {contacts[name].PhoneNumber}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        public void ListAllContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Contact Name: {contact.Key}, Phone Number: {contact.Value.PhoneNumber}");
            }
        }
    }
}