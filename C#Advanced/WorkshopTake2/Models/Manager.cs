namespace Models
{
    public class Manager : User
    {
        public Manager(string firstName, string lastName, string username) : base(firstName, lastName, username, Role.Manager)
        {
        }
    }
}
