using DataAccess;
using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class DriverCarService : IDriverCarService
    {
        private Storage _storage;
        public DriverCarService()
        {
            _storage = new Storage();
        }
        public void AssignDriverToCar(int driverId, int carId, int shift)
        {
            var driver =(Driver) _storage.Users.GetById(driverId);

            if (driver.Role != Models.Enums.RoleEnum.Driver)
            {

            }
        }
    }
}
