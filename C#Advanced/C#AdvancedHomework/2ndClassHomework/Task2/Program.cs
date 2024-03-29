using Task2Models;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int workingDays = GetWorkingDays();

            Manager manager1 = new Manager("Johnny",8);
            Manager manager2 = new Manager("Elvis",7);
            Programmer programmer1 = new Programmer("Boris", 3);
            Programmer programmer2 = new Programmer("Risto", 5);
            

            Console.WriteLine(manager1.GetInfo());
            Console.WriteLine($"The manager {manager1.Name} monthly salary is  ${manager1.CalculateSalary(workingDays)}!");
            Console.WriteLine(manager2.GetInfo());
            Console.WriteLine($"The manager {manager2.Name} monthly salary is  ${manager2.CalculateSalary(workingDays)}!");
            Console.WriteLine(programmer1.GetInfo());
            Console.WriteLine($"The programmer {programmer1.Name} monthly salary is  ${programmer1.CalculateSalary(workingDays)}!");
            Console.WriteLine(programmer2.GetInfo());
            Console.WriteLine($"The programmer {programmer2.Name} monthly salary is  ${programmer2.CalculateSalary(workingDays)}!");
        }

        static int GetWorkingDays()
        {
            int workingDays = 0;
            DateTime today = DateTime.Today;
            int daysInMonth = DateTime.DaysInMonth(today.Year,today.Month);
            for (int i = 0; i < daysInMonth ; i++)
            {

                if (today.DayOfWeek == DayOfWeek.Saturday
                    || today.DayOfWeek == DayOfWeek.Sunday)
                {

                    today = today.AddDays(1);
                    continue;
                }
                else
                {
                    workingDays++;
                    today = today.AddDays(1);
                }
            }

            return workingDays;
        }
    }
}
