using Models;

namespace Services.Interfaces
{
    public interface IUserService
    {
        void Login(string username, string password);
        void LogOut();
        void TerminateUser(int id);
    }
}
