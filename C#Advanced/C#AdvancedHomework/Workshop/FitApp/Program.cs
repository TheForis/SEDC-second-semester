using Models;
using Services;
using Storage;

namespace FitApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIService _service = new UIService();
            while (true)
            {
                try
                {
                    _service.RunProgram();
                    if (CurrentSession.LoggedIn.Role == RoleEnum.Trainer)
                    {
                        _service.TrainerMenu();
                        continue;
                    }
                    if (CurrentSession.LoggedIn.Role == RoleEnum.User)
                    {
                        _service.UserMenu();
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }

        }
    }
}
