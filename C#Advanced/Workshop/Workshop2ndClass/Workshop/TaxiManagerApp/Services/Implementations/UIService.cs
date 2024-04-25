using DataAccess;
using Services.Interfaces;

namespace Services.Implementations
{
    public class UIService : IUIService
    {
        private IUserService _userService;

        public UIService()
        {
            _userService = new UserService();   
        }

        public void Login()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please login!");
                    Console.Write("Username: ");
                    var username = Console.ReadLine();

                    Console.Write("Password: ");
                    var password = Console.ReadLine();

                    _userService.Login(username, password);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                }
            }
        }

        public void LogOut()
        {
            Console.WriteLine("Thank you for using our app");
            _userService.LogOut();
        }

        private void TerminateUser()
        {
            var users = Storage.Users.GetAll();
            users.ForEach(x => Console.WriteLine($"{x.Id}. {x.FirstName} {x.LastName} [{x.Role}]"));
            var minId = users.Select(x => x.Id).Min();
            var maxId = users.Select(x => x.Id).Max();

            while (true)
            {
                Console.WriteLine("Enter the ID of the user that you want to terminate: ");
                var selectedUserId = ChooseAnOption(minId, maxId);
                try
                {
                    _userService.TerminateUser(selectedUserId);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The user {selectedUserId} was successfully removed!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
            
    }
}
