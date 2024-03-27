namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopAgain = true;
            while (loopAgain)
            {
                DateTime userInput = UserInput();
                CheckWorkingDay(userInput);

                
                loopAgain = TryAgain();
            }
        }

        static DateTime UserInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter a date in format DD-MM-YYYY");
                string userInput = Console.ReadLine();
                if(DateTime.TryParseExact(userInput,"dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture,System.Globalization.DateTimeStyles.None, out DateTime userResult))
                {
                    return userResult;
                }
                Console.WriteLine("Please enter the date again");
            }
        }

        static void CheckWorkingDay (DateTime userDate)
        {
            List<DateTime> notWorkingDays = new List<DateTime>()
            {
                new DateTime (2024,01,01), new DateTime (2024,01,07), new DateTime(2024,05,01), new DateTime(2024,05,25), new DateTime(2024,08,03), new DateTime(2024,09,08), new DateTime(2024,10,12), new DateTime(2024,10,23), new DateTime(2024,12,08)
            };

            foreach (DateTime day in notWorkingDays)
            {
                if (userDate == day) {
                    Console.WriteLine("Not working day!");
                    break;

                }
                
            }
            if (userDate.DayOfWeek == DayOfWeek.Sunday || userDate.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Not working day!");
            }
            else
            {
                Console.WriteLine("Unfortunatly you have to work!");
            }



        }

        static bool TryAgain()
        {
            Console.WriteLine("Would you like to check another date? Y / N");
            string userInput = Console.ReadLine().ToLower() ;
            if (userInput == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
