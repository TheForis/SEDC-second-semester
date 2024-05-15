namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("App starts...");
            Console.WriteLine("Waiting 2 secs.");


            //Single task
            Task myTask = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Running after 2000ms");
            });
            //myTask.Start();

            Task<int> valueTask = new Task<int>(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("We can now get the number!");
                return 666;
            });

            //valueTask.Start();
            //Console.WriteLine($"The number we got is {valueTask.Result}");



            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("This is executed after 3 seconds!");
            });

            for(int i = 0; i < 200; i++)
            {
                int temp = i;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.Write($"  Task no. {temp}  ");
                });
            }





            Console.ReadLine(); //Zavrshuva aplikacijata, ne go ceka taskot (taskot si otvara nov thread vo pozadina i si go izvrshuva)

        }

    }
}
