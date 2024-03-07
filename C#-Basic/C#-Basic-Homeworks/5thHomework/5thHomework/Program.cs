using System.Reflection.Metadata;

namespace _5thHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime userDate;

            while (true) { 
            Console.WriteLine("Please enter day of birth! DD.MM.YYYY");
            string userInput = Console.ReadLine();

                if(DateTime.TryParseExact(userInput, "dd.MM.yyyy", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.AssumeUniversal, out userDate))
                {
                    break;
                }
                Console.WriteLine("Please enter valid date DD.MM.YYYY");
            }
            int ageResult = AgeCalculator(userDate);
            Console.WriteLine($"You are {ageResult} years old!");
        }


        /*static string AgeCalculator (DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Today;
            int result = currentDate.Year - dateOfBirth.Year;
            if(currentDate.Month == dateOfBirth.Month && currentDate.Day == dateOfBirth.Day)
            {
                return $"You are {result} years old and today is your birthday!!";
            }
            else if(currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day)
            {
                result--;
            }
            else if(currentDate.Month < dateOfBirth.Month)
            {
                result--;
            }


            return $"You are {result} years old";
        }


        ^^^ Mene ova povekje mi se dopagja kako reshenie - ama neznam shto e podobro vo praksa pa ete poednostaven kod podole koj vrakja starost.
*/

        static int AgeCalculator(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Today;
            int result = currentDate.Year - dateOfBirth.Year;
            if (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day)
            {
                result--;
            }
            else if (currentDate.Month < dateOfBirth.Month)
            {
                result--;
            }
            return result;
        }
    }
}
