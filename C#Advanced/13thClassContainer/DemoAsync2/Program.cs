namespace DemoAsync2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetMessage();
            Console.WriteLine("End of the main program");
            Console.ReadLine();
        }
        public static async Task GetMessage()
        {

            Task.Run(() =>
            {
                Console.WriteLine("Entering the function..");
                Thread.Sleep(5000);
                Console.WriteLine("End of function");
            });
        }
        // static async void GetMessage1()
        //{
        //    Console.WriteLine("Entering the function..");
        //    Thread.Sleep(5000);
        //    Console.WriteLine("End of function");
        //}
    }
}
