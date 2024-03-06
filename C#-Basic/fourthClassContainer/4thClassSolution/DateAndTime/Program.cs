using System.Globalization;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            DateTime date2 = new DateTime(2024, 3, 6);
            DateTime date3 = new DateTime(2024, 3, 6,10,30,50);
            DateTime date4 = DateTime.Now;
            DateTime date5 = DateTime.UtcNow;

            DateTime date6 =  date4.AddDays(30);

            Console.WriteLine(date4);
            Console.WriteLine(date5);
            Console.WriteLine(date6);

            Console.WriteLine(date4.ToString(new CultureInfo("en-GB")));
            Console.WriteLine(date4.ToString(new CultureInfo("mk-MK")));
            Console.WriteLine(date4.ToString("ddd*MMMM*yyyy HH-mm-ss-fff zzz"));

        }
    }
}
