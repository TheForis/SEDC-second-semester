namespace Demo2.Models
{
    public class BasketballPlayer : User
    {
        public int Height { get; set; }
        public BasketballPlayer(string firstName, string lastName, string userName, string password, int height) : base(firstName, lastName, userName, password)
        {
            Height = height;
        }

    }
}
