using System.Text;

namespace Exercicse2DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime now = DateTime.Now;

            DateTime threeDaysFromNow = now.AddDays(3);
            Console.WriteLine(threeDaysFromNow);

            DateTime monthFromNow = now.AddMonths(1);
            Console.WriteLine(monthFromNow);

            DateTime monthThreeDaysFromNow = AddDaysAndMonthsFromNow(3,1);
            Console.WriteLine(monthThreeDaysFromNow);

            DateTime yearAnd2MonthsBefore = now.AddYears(-1).AddMonths(-2);
            Console.WriteLine(yearAnd2MonthsBefore);

            Console.WriteLine($"{now.ToString("MMMM")}");

            Console.WriteLine(now.Month);

            Console.WriteLine(now.Year);



        }
        // public - access modifier, defines from where this method can be accessed.
        //static - because Main method(the Main brackets) is static
        //DateTime - return Type, result that the method returns
        // Name of the method
        // (int, string, datetime ) - input parametars to the method, needs to be specified
        public static DateTime AddDaysAndMonthsFromNow(int days, int months)
        {
            DateTime now = DateTime.Now;
            
            return now.AddDays(days).AddMonths(months);
        }


    }
}
