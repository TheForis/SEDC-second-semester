namespace Models
{
    public interface IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public RoleEnum Role { get; set; }
        public virtual string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
