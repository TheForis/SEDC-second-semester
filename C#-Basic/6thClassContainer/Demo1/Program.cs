namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "The whole group of G3 was C#. They find learning this language fun and easy";

            // First way
            int messageDot = message.IndexOf('.');
            if (messageDot == -1)
            {
                Console.WriteLine("Dot was not found");
            }
            else
            {
                string substring = message.Substring(messageDot + 1 );
                Console.WriteLine(substring);
            }

            // Second way
            string[] messageSplit = message.Split('.');
            if (messageSplit.Length > 1) 
            {
                Console.WriteLine(messageSplit[1]);
            }
            else
            {
                Console.WriteLine("Dot was not found");
            }




        }
    }
}
