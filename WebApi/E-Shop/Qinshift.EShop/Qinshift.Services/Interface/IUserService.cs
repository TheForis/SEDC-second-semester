using Qinshift.EShop.DTOs.User;

namespace Qinshift.EShop.Services.Interface
{
    public interface IUserService
    {
        int RegisterUser(RegisterUserDto registerUserDto);
        string LoginUser(string username, string password);
    }
}
