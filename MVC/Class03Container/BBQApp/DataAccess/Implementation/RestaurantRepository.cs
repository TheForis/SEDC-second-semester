using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementation
{
    public class RestaurantRepository : IRepository<Restaurant>
    {
        

        

        public List<Restaurant> GetAll()
        {
            return new List<Restaurant> { StaticDb.Restaurant };
        }

        public Restaurant GetById(int id)
        {
            return StaticDb.Restaurant;
        }
        public void Save(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(Restaurant entity)
        {
            throw new NotImplementedException();
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
