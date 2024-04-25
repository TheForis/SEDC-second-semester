using Newtonsoft.Json;

namespace Demo2JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //var user = new User()
            //{
            //    FirstName = "Risto",
            //    LastName = "Panchevski",
            //    Age = 34
            //};
            if (!Directory.Exists("Storage"))
            {
                Directory.CreateDirectory("Storage");
            }

            var user = new User("Risto", "Panchevski", 34);
            string filePath = @"Storage\data.json";
            string serializedUser = JsonConvert.SerializeObject(user);
            
            using(var sw = new StreamWriter(filePath,true))
            {
                sw.Write(serializedUser);
            }

            var deserializedUser = JsonConvert.DeserializeObject<User>(serializedUser);

            int a = 5;
            var intSerialized = JsonConvert.SerializeObject(a);
        }
    }
}
