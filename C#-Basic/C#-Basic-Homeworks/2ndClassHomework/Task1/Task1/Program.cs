namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 15;
            int thirdNumber = 20;
            int fourthNumber = 30;
            int avgResult = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is {avgResult}!");
        }
    }
}
