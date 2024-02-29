namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            string firstInput = Console.ReadLine();

            int firstParsedInput;
            bool firstParse = int.TryParse(firstInput, out firstParsedInput);
            if (!firstParse)
            {

                Console.WriteLine("Please enter a valid number");
                return;
            }

            Console.WriteLine("Please enter the second number");
            string secondInput = Console.ReadLine();

            int secondParsedInput;
            bool secondParse = int.TryParse(secondInput, out secondParsedInput);
            if (!secondParse)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }

            Console.WriteLine($"First user input: {firstParsedInput}, second user input:{secondParsedInput}");

            int firstValueHolder = firstParsedInput;
            firstParsedInput = secondParsedInput;
            secondParsedInput = firstValueHolder;

            Console.WriteLine($"SWAPPED~~ First value = {firstParsedInput}, Second value = {secondParsedInput}");
        }
    }
}
