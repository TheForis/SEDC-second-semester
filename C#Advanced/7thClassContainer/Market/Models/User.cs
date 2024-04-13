namespace MarketApp.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public CategoryEnum FavoriteCategory { get; set; }
        public void NewPromotion (Product product, int newPrice)
        {
            if(product.Category == FavoriteCategory)
            {
                Console.WriteLine($"Your Lucky day! {FullName}.  The product {product.Name} is on sale! The old price was {product.Price} -> new price {newPrice}!!");
            }
            if(FavoriteCategory == CategoryEnum.All)
            {
                Console.WriteLine($"{FullName} You are one lucky motherF");
            }
        }
    }
}
