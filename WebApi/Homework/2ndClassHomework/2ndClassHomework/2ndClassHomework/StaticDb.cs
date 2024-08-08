namespace _2ndClassHomework
{
    public static class StaticDb
    {
        public static List<User> Users = new List<User>()
        {
            new User
            {
                FirstName = "Bob",
                LastName = "Bobsky",
            },
            new User
            {
                FirstName= "Boris",
                LastName = "Krstovski"
            },
            new User
            {
                FirstName = "Trale",
                LastName = "Trajkovski"
            }
        };
    }
}
