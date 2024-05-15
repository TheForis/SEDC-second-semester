namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Execution time = Thread

            //SendMessages();
            //SendMessagesWithThreads();
            
            
            
        }






        //Single threaded
        static void SendMessages () 
        {
            Console.WriteLine("Getting Ready...");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep (2000);
            Console.WriteLine("Second message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived!");
            Console.WriteLine("All messages revieved!");
            Console.ReadLine();
        }
        //manually opening new threads. Bad practice
        static void SendMessagesWithThreads()
        {
            Console.WriteLine("Getting Ready...");
            Thread.Sleep(2000);
            Thread myThread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("First message arrived!");
            });
            myThread.Start();
            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second message arrived!");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Third message arrived!");
                
            }).Start();

            Console.WriteLine("All messages revieved!");
            Console.ReadLine() ;
        }

    }
}
