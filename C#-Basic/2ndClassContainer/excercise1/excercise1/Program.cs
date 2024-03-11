namespace excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstDecimal = 5.555;
            double secondDecimal = 6.666;

            double result = firstDecimal / secondDecimal;
            Console.WriteLine(result);

            int firstNumber = 203;
            int secondNumber = 100;

            double resultInteger = firstNumber / (double)secondNumber;
            Console.WriteLine(resultInteger);
        }
    }
}
