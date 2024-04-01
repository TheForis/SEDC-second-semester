namespace Task1.Models
{
    public static class UserDatabase
    {
        static List<User> Users { get; set; } = new List<User>();

        public static void AddUser(User user)
        {
            if (Users.Contains(user))
            {
                throw new Exception("User already exists!");
            }
            if (string.IsNullOrEmpty(user.Name) || user.Name.Length <= 1)
            {
                throw new Exception("Invalid User name!");
            }
            else
            {
                Users.Add(user);
            }
        }
        public static User SearchById(int id)
        {
            foreach (var user in Users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }
        public static List<User> SearchByName(string name)
        {
            List<User> userResult = new List<User>();
            foreach (var user in Users)
            {
                if (user.Name.ToLower() == name.ToLower()) 
                {
                    userResult.Add(user);
                }
            }
            if (!userResult.Any())
            {
                return null;
            }
            return userResult;
        }
        public static List<User> SearchByAge(int age)
        {
            List<User> userResult = new List<User>();
            foreach (var user in Users)
            {
                if(user.Age == age)
                {
                    userResult.Add(user);
                }
            }
            if (!userResult.Any())
            {
                return null;
            }
            return userResult;
        }
    }
}
