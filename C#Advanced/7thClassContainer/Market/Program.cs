using MarketApp.Models;

namespace MarketApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var marketVero = new MarketClass()
            {
                Name = "Vero",
                Products = new List<Product> 
                {
                    new Product
                    {
                        Name= "Beef",
                        Category = CategoryEnum.Meat,
                        Price = 700
                    },
                    new Product
                    {
                        Name = "Potato",
                        Category = CategoryEnum.Vegetables,
                        Price = 30
                    },
                    new Product
                    {
                        Name = "Tomato",
                        Category = CategoryEnum.Vegetables,
                        Price = 129
                    },
                    new Product
                    {
                        Name = "Chicken Breast",
                        Category = CategoryEnum.Meat,
                        Price = 249
                    }

                }
            };

            var user1 = new User()
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                FavoriteCategory = CategoryEnum.Meat
            };
            var user2 = new User
            {
                FirstName = "Boris",
                LastName = "Krstovski",
                FavoriteCategory = CategoryEnum.Vegetables
            };

            marketVero.Subscribe(user1.NewPromotion);
            marketVero.Subscribe(user2.NewPromotion);
            marketVero.CreatePromotion();

        }
    }
}
