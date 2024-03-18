namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> bankQueue = new Queue<string>();

            bankQueue.Enqueue("Risto");
            bankQueue.Enqueue("Slave");
            bankQueue.Enqueue("Sasho");

            string namePeek = bankQueue.Peek();
            Console.WriteLine(namePeek);

            string nextInLine = bankQueue.Dequeue();
            Console.WriteLine(nextInLine);
            Console.WriteLine(bankQueue.Dequeue());
            Console.WriteLine(bankQueue.Dequeue());
            /*Console.WriteLine(bankQueue.Dequeue());*//**/

            bankQueue.Enqueue("Boris");

            bool successDeQueue = bankQueue.TryDequeue(out string name3);
            bool successDeQueue2 = bankQueue.TryDequeue(out string name4);
            Console.WriteLine(name3);
            Console.WriteLine(name4);


        }
    }
}
