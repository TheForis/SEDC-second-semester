using System.Text;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*Console.WriteLine("Ве молам внесете број:");
            string userInput = Console.ReadLine();

            if(!int.TryParse(userInput, out int userNumber)){
                Console.WriteLine("Невалиден број");
                return;
            }

            Console.WriteLine($"Одличен број. Вашиот број е:{userNumber}");*/
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

            Console.WriteLine($"Одличен број. Вашиот број е:{userNumber}");



        }
    }
}
