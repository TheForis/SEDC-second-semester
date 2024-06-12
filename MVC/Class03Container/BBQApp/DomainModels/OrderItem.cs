namespace DomainModels
{
    public class OrderItem : BaseClass
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}
