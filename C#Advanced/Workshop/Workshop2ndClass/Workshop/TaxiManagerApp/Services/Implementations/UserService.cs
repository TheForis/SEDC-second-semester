using DataAccess;
using Models;
using Services.Interfaces;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        public void Login(string username, string password)
        {
            var loginUser = Storage.Users.GetAll().FirstOrDefault(x => x.Username == username);

            if (loginUser == null)
                throw new Exception("Non existing user!");

            if(!loginUser.CheckPassword(password))
            {
                throw new Exception("Wrong password!");
            }

            CurrentSession.CurrentUser = loginUser;
        }

        public void LogOut()
        {
            CurrentSession.CurrentUser = null;
        }
        public void TerminateUser(int id)
        {
            var user = Storage.Users.GetById(id);

            var carsDriverByDriver = Storage.Cars.GetAll().Where(x=> x.Drivers.Any(y=> y.Value.Id == id));

            foreach(var car in carsDriverByDriver)
            {
                var shiftDriverPair = car.Drivers.FirstOrDefault(x => x.Value.Id == user.Id);
                car.Drivers.Remove(shiftDriverPair.Key);
                
                Storage.Cars.Update(car);
            }

            Storage.Users.Delete(user);

        }
    }
}
