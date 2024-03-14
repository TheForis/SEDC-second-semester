namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal userNumber = UserInputGetter();

                NumberStats numberToCheck = new NumberStats(userNumber);
                Console.WriteLine(numberToCheck.GetNumberStats());

                if (!TryAgain())
                {
                    break;
                }

            }

        }

        static decimal UserInputGetter()
        {
            while (true)
            {
                Console.Write("Please enter a number -> ");
                string userInput = Console.ReadLine();

                if (decimal.TryParse(userInput, out decimal parsedNumber))
                {
                    return parsedNumber;
                }
                Console.WriteLine("Please enter a valid number!");
            }
        }

        static bool TryAgain ()
        {
            while (true)
            {
                Console.Write("Do you want to try again? [Y / X] -> ");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "Y" || userAnswer == "y")
                {
                    return true;
                }
                else if (userAnswer == "X" || userAnswer == "x")
                {
                    Console.WriteLine("Thank you for using our application!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer! Y or X ");
                }
            }
        }
    }
}
