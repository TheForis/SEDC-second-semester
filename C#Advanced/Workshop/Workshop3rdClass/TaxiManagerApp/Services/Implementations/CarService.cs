using DataAccess;
using Services.Interfaces;

namespace Services.Implementations
{
    public class CarService : ICarService
    {
        private Storage _storage;
        public CarService()
        {
            _storage = new Storage();
        }
        public void CreateCar(string licencePlate, DateTime licencePlateexpiryDate, string model)
        {
            if(_storage.Cars.GetAll().Any(x=> x.LicensePlate.ToLower() == licencePlate.ToLower())) 
            {
                throw new Exception($"Car with licence plate {licencePlate} already exists in the system!");
            }
        }
    }
}
