using Demo2.Models;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region data

            User[] users = new User[] 
            { 
                new User(){Id = 10, Username = "borisKrstovski", Password = "password", messages = new string[]{"Pozdrav od QINSHIFT", "Zdravo, domashnata mi e prikachena na repo! Link zaboraiv!" } },
                new User(){Id = 22,Username = "sasho",Password = "password123", messages = new string[] { "Imame chas vo ponedelnik", "Domashnata e lesna" }},
                new User(){Id = 23,Username="slave123",Password = "slave321", messages = new string[]{"Hi i am bob!", "I'm very famous in programming examples!","I bla bla bla" } }
            };
            #endregion
            while (!UserUI()) {

            }


        }
        static void LogIn(User[] users, string username, string password)
        {

            User user = FindUser(users, username, password);
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Welcome {user.Username}");
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine("Your messages");
            foreach (string message in user.messages)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        
        static User FindUser(User[] users, string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.ToLower() == username.ToLower() && user.Password == password)
                {
                    return user;
                }
                
            }
            return null;
        }

        static void Register(User[] users, string username, string password, int id)
        {
            User user = FindUser(users,username,password);
            if (user != null)
            {
                Console.WriteLine("User already exists");
                return;
            }
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = new User() { Id = id,Username=username, Password=password };
            Console.WriteLine("Successfully registered!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Users registered so far:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach(User u in users)
            {
                Console.WriteLine($"ID: {u.Id}, Username: {u.Username}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");



        }

        static bool UserUI(User[] users)
        {
            Console.WriteLine("Choose: \n1) Log in \n2) Register");
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);
            if (!isNumber)
            {
                Console.WriteLine("That was not a number, please try again!");
                return false;
            }
            switch (choice) 
            {
                case 1:
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    LogIn(users, username, password);
                    return true;
                case 2:
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter username: ");
                    string newUsername = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string newPassword = Console.ReadLine();
                    Register(users, newUsername, newPassword, id);
                    return true;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    return false;
            }
        }

    }
}
