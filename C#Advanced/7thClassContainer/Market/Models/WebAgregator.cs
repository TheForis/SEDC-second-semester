using MarketApp.Models;

namespace Market.Models
{
    public class WebAgregator
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public void NewProductPromotion(Product p, int price)
        {
            Console.WriteLine($"This");
        }
    }
}
