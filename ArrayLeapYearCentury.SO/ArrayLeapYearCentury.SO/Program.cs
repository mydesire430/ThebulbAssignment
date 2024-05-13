namespace ArrayLeapYearCentury.SO
{
    internal class Program
    {
        static void Main()
        {
            int[] years = { 1923, 2022, 2000, 500 };

            // Validate years
            if (years.Any(y => y > DateTime.Today.Year))
            {
                Console.WriteLine("Error: Year cannot be in the future.");
                return;
            }

            // Find leap years
            var leapYears = years.Where(y => IsLeapYear(y)).ToList();
            Console.WriteLine("Leap years:");
            foreach (var year in leapYears)
            {
                Console.WriteLine(year);
            }
            Console.WriteLine($"Count: {leapYears.Count}");

            // Find century for each year
            foreach (var year in years)
            {
                Console.WriteLine($"Year {year} falls in the {GetCentury(year)} century.");
            }
        }

        static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        static int GetCentury(int year)
        {
            return (year - 1) / 100 + 1;
        }
    }
    }
