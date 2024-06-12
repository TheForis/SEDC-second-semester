namespace DomainModels
{
    public class Order : BaseClass
    {
        public DateTime OrderTime { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
