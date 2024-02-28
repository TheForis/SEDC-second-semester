namespace excercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 102;
            int m = 5;
            int result = n / m;
            int creditsResult = n % m;
            Console.WriteLine($"You have {n} credits and you can send {result} SMS messages. You will have {creditsResult} credits left after the messages");
        }
    }
}
