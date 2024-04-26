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
            string folderPath = @"..\..\..\..\Data";
            string trainingsPath = $@"{folderPath}\trainings.json";
            if (!Directory.Exists(folderPath)){
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(trainingsPath)) {
                File.Create(trainingsPath).Close();
            }

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
