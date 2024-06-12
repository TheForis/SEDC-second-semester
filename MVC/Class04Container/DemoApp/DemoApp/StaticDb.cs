using ViewModels;
namespace DemoApp;

public class StaticDb
{
    public static List<UserViewModel> users = new List<UserViewModel>()
    {
        new UserViewModel
        {
            Id = 1,
            FirstName = "Test",
            LastName = "Test",
            Age = 26
        },
        new UserViewModel
        {
            Id = 2,
            FirstName = "Test",
            LastName = "Test",
            Age = 36
        },new UserViewModel
        {
            Id = 3,
            FirstName = "Test",
            LastName = "Test",
            Age = 46
        },
    };
}
