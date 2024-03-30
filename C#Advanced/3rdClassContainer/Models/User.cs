namespace Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }

        protected User(string name,string userName,string password) 
        { 
            Random rnd = new Random();
            Id = rnd.Next(1,int.MaxValue);
            Name = name;
            UserName = userName;
            Password = password;
        }
/*
        public abstract string GetUser();*/

        public virtual string GetUser()
        {
            return $"{Id}: {Name} [{UserName}]";
        }
    }
}