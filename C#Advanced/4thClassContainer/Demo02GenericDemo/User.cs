namespace ModelsDemo02
{
    public class User : BaseClass
    {
        public string Id {get;set }
        public string Name { get; set; }
        public string UserName { get; set; }

        

        public User(string name,string userName,string id,string createdBy) : base(createdBy)
        {
            Name = name;
            UserName = userName;
            Id = id;
        }
    }
}
