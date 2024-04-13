namespace MarketApp.Models
{
    public class MarketClass
    {
        public delegate void PromotionDelegate(Product p, int newPrice);
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public event PromotionDelegate Subscribers;

        public void Subscribe(PromotionDelegate func)
        {
            if (Subscribers == null)
            {
                Subscribers = func;
            }
            else
            {
                Subscribers += func;
            }
        }
        public void UnSubscribe (PromotionDelegate func)
        {
            if(Subscribers != null)
            {
                Subscribers -= func;
            }
        }

        public void  CreatePromotion()
        {
            Random rnd = new Random();
            var index = rnd.Next(0,Products.Count);
            var productOnPromotion = Products[index];
            var newPrice = (int)(Math.Round((productOnPromotion.Price * 0.8),0));

            Subscribers(productOnPromotion, newPrice);
        }

        
    }
}
