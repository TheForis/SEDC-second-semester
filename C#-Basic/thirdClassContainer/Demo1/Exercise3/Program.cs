using System.Diagnostics.Metrics;
using System.Text;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =Encoding.UTF8;
            int counter = 0;
            int userNumber;
            while (true)
            {
                Console.WriteLine("Ве молам внесете број:");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userNumber))
                {
                    break;
                }
                Console.WriteLine("Невалиден внес");

            }

            for(int i = 1; i<=userNumber;i++)
            {
                if (i%3 ==0 || i%7==0)
                {
                    continue;
                }

                Console.WriteLine(i);
                counter++;
                if(counter == 100)
                {
                    break;
                }
                
                
            }








        }
    }
}
