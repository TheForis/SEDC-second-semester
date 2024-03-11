namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string firstUserInput = Console.ReadLine();

            Console.WriteLine("Enter second number");
            string secondUserInput = Console.ReadLine();

            if(!int.TryParse(firstUserInput, out int firstInput))  {
                Console.WriteLine("Please enter a number");
                return;
            }
            if (!int.TryParse(secondUserInput, out int secondInput))
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            if(firstInput > secondInput)
            {
                Console.WriteLine($"The first number is larger");
            }
            else if(secondInput > firstInput)
            {
                Console.WriteLine($"The second number is larger");
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }


            if (firstInput % 2 == 0) {
                Console.WriteLine($"The first number is even");
            }
            else
            {
                Console.WriteLine($"The first number is odd");
            }

            if (secondInput % 2 == 0)
            {
                Console.WriteLine($"The second" +
                    $" number is even");
            }
            else
            {
                Console.WriteLine($"The second number is odd");
            }
        }
    }
}
