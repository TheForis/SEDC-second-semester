using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DATA
            User user1 = new User("Boris", 32);
            User user2 = new User("Risto", 34);
            User user3 = new User("Sasho", 19);
            User user4 = new User("Slave", 20);
            User user5 = new User("Boris", 38);
            User user6 = new User("Sirma", 34);
            User user7 = new User("Elena", 25);
            User user8 = new User("Vladimir", 33);
            User user9 = new User("Simona", 27);
            User user10 = new User("Stefan", 34);

            List<User> users = new List<User>() { user1,user2,user3,user4,user5,user6,user7,user8,user9,user10};

            string[] messages = { "Please enter an ID number: ","Please enter a name: ", "Please enter age: " };
            #endregion
            try
            {
                foreach (User user in users)
                {
                    UserDatabase.AddUser(user);
                }
            } catch (Exception ex) { 
                Console.WriteLine(ex.ToString()); 
            }

            bool loopAgain = true;

            while (loopAgain)
            {
                switch (UserChooser())
                {
                    case "1":
                        if (int.TryParse(UserInput(messages[0]),out int inputResultId))
                        {
                            User userById = UserDatabase.SearchById(inputResultId);
                            if (userById != null)
                            {
                                PrintResult(userById);
                                loopAgain = TryAgain();
                                break;
                            }
                            Console.WriteLine("No user found!");
                            loopAgain= TryAgain();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number!");
                            loopAgain = TryAgain();
                            break;
                        }
                    case "2":
                        string userInput = UserInput(messages[1]);
                        if (string.IsNullOrEmpty(userInput))
                        {
                            Console.WriteLine("Please enter a Name!");
                            loopAgain = TryAgain();
                            break;
                        }
                        List<User> resultList = UserDatabase.SearchByName(userInput);
                        if (resultList == null) {
                            Console.WriteLine("No user/s found!");  
                            loopAgain = TryAgain();
                            break; 
                        }
                        else
                        {
                            foreach (User user in resultList)
                            {
                                PrintResult(user);
                            }
                            loopAgain = TryAgain();
                            break;
                        }
                    case "3":
                        if (int.TryParse(UserInput(messages[2]),out int inputResult))
                        {
                            List<User> resultByAge = UserDatabase.SearchByAge(inputResult);
                            if (resultByAge == null) { 
                                Console.WriteLine("No user/s found!");
                                loopAgain = TryAgain();
                                break;
                            }
                            else
                            {
                                foreach (User user in resultByAge)
                                {
                                    PrintResult(user);
                                }
                                loopAgain = TryAgain();
                                break;
                            }
                        }
                        Console.WriteLine("Please enter a valid number!");
                        loopAgain = TryAgain();
                        break;
                    default: 
                        Console.Clear();
                        Console.WriteLine("Please choose between 1, 2 or 3!");
                        break;

                        
                }
            }



            

        }
        static string UserChooser()
        {
            Console.WriteLine("Would you like to search by \n1) ID \n2) Name \n3)Age");
            return Console.ReadLine();
        }
        static string UserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        static void PrintResult(User user)
        {
            Console.WriteLine($"ID: [{user.Id}] Name:{user.Name}. {user.Age} years old.");
        }
        static bool TryAgain()
        {
            Console.WriteLine("Enter Y to search again!");
            if(Console.ReadLine().ToUpper()== "Y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Thank you for using our app!");
                return false;
            }
        }
    }
    
}
