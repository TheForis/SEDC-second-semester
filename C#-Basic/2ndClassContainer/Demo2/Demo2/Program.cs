namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Number:");
            string userInput = Console.ReadLine();

            int parsedNumber;
            bool success1 = int.TryParse(userInput,out parsedNumber);
            if(!success1 )
            {
                Console.WriteLine("Please Enter a valid number");
                return;
            }

            float result = parsedNumber / 2f;
            Console.WriteLine($"The number you entered slashed in half is {result}");

            Console.WriteLine("Enter second number to add to the first number:");
            string userInput2 = Console.ReadLine();

            int secondParsedNumber;
               /* int.Parse(userInput2);*/
            bool success2 = int.TryParse(userInput2 ,out secondParsedNumber);

            if (!success2)
            {
                Console.WriteLine("Please enter valid number");
                return;
            }
            int secondResult = secondParsedNumber + parsedNumber;
            Console.WriteLine($"{parsedNumber} + { secondParsedNumber} = { secondResult}");





        }
    }
}
