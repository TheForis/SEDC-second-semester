using DataAccess.Implementation;
using DataAccess.Interfaces;
using DomainModels;
using Services.Interfaces;
using ViewModels;

namespace Services.Implementation
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRepository<Restaurant> _restaurantRepository;
        public RestaurantService()
        {
            _restaurantRepository = new RestaurantRepository();
        }
        public RestaurantViewModel GetRestaurantDetails()
        {
            var restaurant = _restaurantRepository.GetAll().FirstOrDefault();
            if (restaurant == null)
            {
                throw new Exception("Restaurant not found!");
            }

            var restaurantViewModel = new RestaurantViewModel();
                restaurantViewModel.Id = restaurant.Id;
                restaurantViewModel.Name = restaurant.Name;
                restaurantViewModel.Menu = new List<MenuItemViewModel>();
        
                foreach(var restaurantMenuItem in restaurant.Menu)
                {
                    var menuItem = new MenuItemViewModel();
                    menuItem.Id = restaurantMenuItem.Id;
                    menuItem.Name = restaurantMenuItem.Name;
                    menuItem.Description = restaurantMenuItem.Description;
                    menuItem.Price = restaurantMenuItem.Price;

                    restaurantViewModel.Menu.Add(menuItem);

                }
                return restaurantViewModel;
            }




    }
}
