namespace SubstringsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int userNumber;
            while (true)
            {
                Console.Write("Please enter a number:");
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out userNumber)){
                    break;
                }
                Console.WriteLine("Please enter a valid number");
            }

            string methodResult = Substrings(userNumber);
            Console.WriteLine(methodResult);


            /*Substrings(userNumber);*/


        }
        static string Substrings(int number)
        {
            string message = "Hello from QINSHIFT Codecademy 2024";
            if (number < 1)
            {
                return "Please enter a positive number!";

            }
            else if (number > message.Length)
            {
                return "Please enter lower number";
            }
            string changedMessage = message.Substring(0, number);
            Console.WriteLine($"The length of the new string is: {changedMessage.Length} characters.");
            return changedMessage;
        }


            /* static void Substrings(int number)
             {
                 string message = "Hello from QINSHIFT Codecademy 2024";
                 if (number < 1)
                 {
                     Console.WriteLine( "Please enter a positive number!");
                     return;

                 }
                 else if (number > message.Length)
                 {
                     Console.WriteLine("Please enter lower number");
                     return;
                 }
                 string changedMessage = message.Substring(0, number);
                 Console.WriteLine(changedMessage);
                 Console.WriteLine($"The length of the new string is: {changedMessage.Length} characters.");
             }*/
        }
}
