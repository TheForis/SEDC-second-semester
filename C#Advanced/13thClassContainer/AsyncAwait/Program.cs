namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            MainThread();
            Console.WriteLine("Helloooooooo");
            SendMessage("Zdravoooo");

            //var x = SendAsyncMessage("Hey there students from Qinshift academy");
            //Console.WriteLine($"The status of the async method is {x.Status}");

            Console.ReadLine();
        }

        static async Task MainThread()
        {
            await SendAsyncMessage("Hey there students from Qinshift academy");
            ShowAd("Potato");
            var number = await GetSomeRandomNumber();
            var summedNumber = number + 500;
            Console.WriteLine($"The summed number from the number is {summedNumber}");
            await SendAsyncMessage("Hey there students from Qinshift academy");
            ShowAd("Popcorn");
        }






        static void SendMessage(string message)// Synchronous method
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(4000);
            Console.WriteLine($"The message: {message} was sent!");
        }


        //async method
        static async Task SendAsyncMessage(string message)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message: {message} was sent!");
            });
        }
        static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let uss show you an ad!");
            Console.WriteLine("Buy the best product in the world");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(product);
            Console.ResetColor();
            Console.WriteLine("now and get");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("FREE");
            Console.ResetColor();
            Console.WriteLine("shipping worldwide");

        }
        static async Task<int> GetSomeRandomNumber()
        {
            Thread.Sleep(3000);
            Random random = new Random();
            int number = random.Next(0, 101);
            return number;

        }

    }


}
