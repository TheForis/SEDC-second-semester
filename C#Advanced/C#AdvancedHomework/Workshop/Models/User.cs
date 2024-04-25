namespace Models
{
    public class User : BaseUser, IUser
    {
        public bool IsPremium { get; set; } = false;
        public User(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password, RoleEnum.User)
        {
        }
        public void GetPremium()
        {
            IsPremium = true;
        }
        public void RemovePremium()
        {
            IsPremium = false;
        }
    }
}
