namespace Models
{
    public class Maintenance : User
    {
        public Maintenance(string firstName, string lastName, string username) : base(firstName, lastName, username, Role.Maintenance)
        {
        }
    }
}
