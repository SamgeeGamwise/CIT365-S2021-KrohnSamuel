using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            ChristmasCountdown(DateTime.Now);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            GlazerApp.RunExample();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /*
            Prompts for name and location and assigns to a new Person
        */
        static private void GetUserNameAndLocation()
        {
            Person person = new Person();
            
            Console.WriteLine("What is your name?");
            person.SetName(Console.ReadLine());

            Console.WriteLine($"Hi {person.GetName()}! Where are you from?");
            person.SetLocation(Console.ReadLine());

            Console.WriteLine($"I have never been to {person.GetLocation()}. I bet it is nice.");
        }

        /*
             Accepts a DateTime as a parameter (expects current date) and displays that date and the number of days until Christmas in the Console
        */
        static private void ChristmasCountdown(DateTime dateTime)
        {
            Console.WriteLine($"Today's date is: {dateTime.ToString("MMMM dd, yyyy")}");
            DateTime christmas = new DateTime(
                dateTime.Month == 12 && dateTime.Day > 25 ? dateTime.Year + 1 : dateTime.Year,
                12,
                25
            );

            int daysUntilChristmas = (christmas.Date - dateTime.Date).Days;

            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas");
        }
    }
}
