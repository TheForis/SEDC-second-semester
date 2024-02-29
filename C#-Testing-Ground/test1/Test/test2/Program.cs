namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string firstUserInput = Console.ReadLine();

            int firstInput;
            bool firstInputBool = int.TryParse(firstUserInput, out firstInput);
            if (!firstInputBool )
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Enter second number");
            string secondUserInput = Console.ReadLine();

            int secondInput;
            bool secondInputBool = int.TryParse(secondUserInput, out secondInput);
            if (!secondInputBool)
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            if (secondInput > firstInput)
            {
                Console.WriteLine($"The Second number: {secondInput} is larger");
                if ( secondInput % 2 == 0 ) {
                    Console.WriteLine($"The number: {secondInput} is even");
                        }
                else
                {
                    Console.WriteLine($"The number: {secondInput} is odd");

                }
            }
            else
            {
                Console.WriteLine($"The First number: {firstInput} is larger");
                if (secondInput % 2 == 0)
                {
                    Console.WriteLine($"The number: {firstInput} is even");
                }
                else
                {
                    Console.WriteLine($"The number: {firstInput} is odd");

                }
            }





        }
    }
}
