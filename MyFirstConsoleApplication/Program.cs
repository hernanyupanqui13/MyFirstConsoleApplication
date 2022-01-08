using System;
using System.Globalization;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ChristmasCountdown(DateTime.Now);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            GlazerApp.RunExample();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }

        // Gets the user name and location by asking to the user
        private static void GetUserNameAndLocation()
        {
            Person person = new Person();

            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"I have never been to {person.location}. I bet it is nice.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);


        }


        // Display the current date and the number of days until christmas
        private static void ChristmasCountdown(DateTime dateTime)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            
            DateTime christmas = DateTime.ParseExact("25/12/2022", "dd/MM/yyyy", cultureInfo);

            double dateDiff = (christmas - dateTime).TotalDays;


            Console.WriteLine($"Today date is {dateTime.ToString("MMMM", cultureInfo)} {dateTime.Day}, {dateTime.Year}");
            Console.WriteLine($"There are {Math.Ceiling(dateDiff)} days until Christmas!");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }
    }
}
