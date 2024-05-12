namespace Arrayofusers.SO
{
    public class Program
    {
        static void Main()
        {
            var users = new List<User>();
            int userCount = 0;

            while (true)
            {
                Console.WriteLine("Enter 1 to add a user, or 0 to exit:");
                var input = Console.ReadLine();

                if (input == "0")
                {
                    break;
                }

                AddUser(users, ref userCount);
            }
        }

        static void AddUser(List<User> users, ref int userCount)
        {
            User user = new User();
            Console.WriteLine("Enter name: ");
            user.Name = GetValue("Name", 4);
            Console.WriteLine("Enter Email: ");
            user.Email = GetValue("Email");
            Console.WriteLine("Enter Password: ");
            user.Password = GetValue("Password", 8);
            Console.WriteLine("Enter Phone Number: ");
            user.PhoneNumber = "+234" + GetValue("Phone Number", 11);
            Console.WriteLine("Enter address: ");
            user.Address = GetValue("Address");
            Console.WriteLine("Enter gender(male/female): ");
            user.Gender = GetValue("Gender" + new[] { "male", "female" });
            users.Add(user);
            userCount++;
            Console.WriteLine("User added successfully!");
        }

        static string GetValue(string propertyName, int minLength = 0, string[] allowedValues = null)
        {
            while (true)
            {
                var value = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("{propertyName} is required.");
                    continue;
                }

                if (minLength > 0 && value.Length < minLength)
                {
                    Console.WriteLine("{propertyName} must be at least {minLength} characters long.");
                    continue;
                }

                if (allowedValues != null && Array.IndexOf(allowedValues, value.ToLower()) == -1)

                {
                    Console.WriteLine("Invalid {propertyName}. Allowed values are: {string.Join(", ", allowedValues)}");
                    continue;
                }

                return value;
            }
        }
    }
}