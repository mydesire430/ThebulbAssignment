namespace ContactBook.SO
{
    public class Program
    {
        static void Main()
        {
            ContactBook book = new ContactBook();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Contact Book Menu:");
                Console.WriteLine("1. Add a new contact.");
                Console.WriteLine("2. Remove an existing contact.");
                Console.WriteLine("3. Find a contact by name.");
                Console.WriteLine("4. List all contacts.");
                Console.WriteLine("5. Exit the program.");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name of the contact: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the phone number of the contact: ");
                        string phoneNumber = Console.ReadLine();
                        book.AddContact(name, phoneNumber);
                        break;
                    case 2:
                        Console.Write("Enter the name of the contact to remove: ");
                        string nameToRemove = Console.ReadLine();
                        book.RemoveContact(nameToRemove);
                        break;
                    case 3:
                        Console.Write("Enter the name of the contact to find: ");
                        string nameToFind = Console.ReadLine();
                        book.FindContact(nameToFind);
                        break;
                    case 4:
                        book.ListAllContacts();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}