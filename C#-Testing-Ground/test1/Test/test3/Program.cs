namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 3");
            string userInput = Console.ReadLine();

            int parsedUserInput;
            bool inputFromUser = int.TryParse(userInput, out parsedUserInput);
            /*if (!inputFromUser)
            {
                Console.WriteLine("Please enter a number");
                
            }*/

            switch (parsedUserInput)
            {
                case 1: Console.WriteLine("You got a new car!");
                break;
                    case 2: Console.WriteLine("You got a new plane!");
                    break;
                    case 3: Console.WriteLine("You got a new bike!");
                    break;
                    default: Console.WriteLine("You've entered a character or wrong number :(");
                    break;
            }
        }
    }
}
