using Models;

namespace Storage
{
    public static class StorageSpace
    {
        public static List<User> Users = new List<User>();
        public static List<Trainer> Trainers = new List<Trainer>()
        {
            new Trainer("Risto", "Panchevski", "trainerRisto", "risto1"),
            new Trainer("Slave", "Ivanovski", "trainerSlave", "Slave1")
        };
        public static Dictionary<BaseUser, List<DateTime>> LiveTrainings = new Dictionary<BaseUser, List<DateTime>>();
        public static void AddUser(User user)
        {
            if (Users.Contains(user))
            {
                throw new Exception($"User with {user.Username} exists!");
            }
            Users.Add(user);

        }



    }
}
