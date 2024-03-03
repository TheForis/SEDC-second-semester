namespace printingNumbers
{
    internal class PrintingNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;


            while (true)
            {
                Console.WriteLine("Please enter a number");
                string firstUserInput = Console.ReadLine();
                if(int.TryParse(firstUserInput, out firstNumber))
                {
                    break;
                }
                Console.WriteLine("Please enter valid number");
            }

            for (int i = 1; i <= firstNumber; i++)
            {
                Console.Write(i + " ");
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please enter a number");
                string secondUserInput = Console.ReadLine();
                if (int.TryParse(secondUserInput, out secondNumber))
                {
                    break;
                }
                Console.WriteLine("Please enter valid number");
            }

            for (int i = secondNumber; i > 0; i--)
            {
                Console.Write(i + " ");
            }









        }
    }
}
