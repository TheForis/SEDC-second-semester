using Models;
using Storage;
namespace Services
{
    public class UserHelper
    {
        public void Register()
        {

            Console.WriteLine("Welcome to Fitness Home. Please Enter the fields below!");
            while (true)
            {
                Console.Write("Enter your First Name: ");
                string inputFirstName = Console.ReadLine();
                Console.Write("Enter your Last Name: ");
                string inputLastName = Console.ReadLine();
                Console.Write("Enter your username: ");
                string inputUserName = Console.ReadLine();
                Console.Write("Enter your password: ");
                string inputPassword = Console.ReadLine();
                try
                {
                    var createUser = new User(CredentialsCheck.NameCheck(inputFirstName), CredentialsCheck.NameCheck(inputLastName), CredentialsCheck.UsernameCheck(inputUserName), CredentialsCheck.PasswordCheck(inputPassword));
                    StorageSpace.AddUser(createUser);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"User with username: {inputUserName} successfully created!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please try again!");
                }
            }


        }

        public void Login(string username)
        {
            if (StorageSpace.Trainers.Any(x => x.Username == username))
            {
                var trainerLoggedIn = StorageSpace.Trainers.FirstOrDefault(x => x.Username == username);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"User {username} found!.");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Please enter your password: ");
                if (trainerLoggedIn.PasswordCheck(Console.ReadLine()))
                {
                    Console.WriteLine($"Login successfull! Welcome {trainerLoggedIn.FullName()}!");
                    CurrentSession.LoggedIn = trainerLoggedIn;
                    return;
                }
                else
                {
                    return;
                }

            }
            if (StorageSpace.Users.Any(x => x.Username == username))
            {
                var userLoggedIn = StorageSpace.Users.FirstOrDefault(x => x.Username == username);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"User {username} found!.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter your password: ");
                if (userLoggedIn.PasswordCheck(Console.ReadLine()))
                {
                    Console.WriteLine($"Login successfull! Welcome {userLoggedIn.FullName()}!");
                    CurrentSession.LoggedIn = (User)userLoggedIn;
                    return;
                }
                else { return; }

            }
            else
            {
                throw new Exception($"No user with username: {username} found! \nPlease try again!");
            }
        }


    }
}
