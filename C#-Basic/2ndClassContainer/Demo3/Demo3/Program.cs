namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the rating:");
            string userInput = Console.ReadLine();

            /*decimal userRating;

            bool success = decimal.TryParse(userInput, out userRating);
            if (!success)
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                Console.WriteLine($"Your rating is: {userRating}");
            }*/





          /*  bool success = decimal.TryParse(userInput, out decimal userRating);
            if (!success)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            Console.WriteLine($"Your rating is: {userRating}");*/





            if(!decimal.TryParse(userInput, out decimal userRating))
            {
                Console.WriteLine("Wrong input");
                return;
            }
            Console.WriteLine($"Your rating is: {userRating}");


        }
    }
}
