namespace Demo1Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class - shablon za kreiranje na objekti. se pravat preku konstruktori
            Console.ForegroundColor = ConsoleColor.Yellow;

            Human trainer = new Human();
            trainer.FirstName = "Risto";
            trainer.LastName = "Pancheski";
            trainer.DateOfBirth = new DateTime(1989, 7, 20);
            string result = trainer.GetPersonStats();

            Console.WriteLine(result);

            Human trainer2 = new Human()
            {
                FirstName = "Slave",
                LastName = "Ivanovski",
                DateOfBirth = DateTime.Now.AddYears(-20)
            };

            Console.WriteLine(trainer2.GetPersonStats());

            Human boris = new Human("Boris", "Krstovski", new DateTime(1992, 6, 03));
            Console.WriteLine(boris.GetPersonStats());

            /*string firstName = GetStringInputFromConsole("Vnesete ime:");
            string lastName = GetStringInputFromConsole("Vnesete prezime:");
            Human trainer3 = new Human()
            {
                FirstName= firstName,LastName= lastName
            };

            Console.WriteLine(trainer3.GetPersonStats());*/

            Human trainer3 = new Human(GetStringInputFromConsole("Vnesete ime"),GetStringInputFromConsole("Vnesete prezime"), DateTime.Now);
            Console.WriteLine(trainer3.GetPersonStats());



        }
        
        public static string GetStringInputFromConsole (string displayMessage)
        {

            Console.WriteLine (displayMessage);
            string input = Console.ReadLine ();
            return input;
        }


    }
}
