namespace exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number between 1 and 3");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1": Console.WriteLine("You've got a new car!!!");
                    break;
                case "2": Console.WriteLine("You've got a new plane!!!");
                    break;
                case "3": Console.WriteLine("You've got a new bike!!!");
                    break;
                default: Console.WriteLine("Sadly you didn't get anything. :(((  Next time enter a number between 1 and 3!");
                    break ;
            }

        }
    }
}
