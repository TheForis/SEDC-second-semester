using System.Text;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                Age = 34
            };

            var userSerialized = SerializeUser(user);
            var userDeserialized = DeserializeUser(userSerialized);


        }

        static string SerializeUser(User user)
        {
            //string result = "{";
            //result += "\"firstName\": \"Risto\"";

            var result = new StringBuilder();
            result.AppendLine("{");
            result.AppendLine($"\"firstName\": \"{user.FirstName}\",");
            result.AppendLine($"\"lastName\": \"{user.LastName}\",");
            result.AppendLine($"\"age\": {user.Age}");
            result.AppendLine("}");


            return result.ToString();
        }
        static User DeserializeUser(string jsonData)
        {
            string [] propertyPairs = jsonData.Replace("\r\n", "").Replace("{","").Replace("}","").Replace("\"","").Split(',');
            Dictionary<string,string> pairs = new Dictionary<string,string>();
            foreach (var pair in propertyPairs)
            {
                var prop = pair.Split(":");
                pairs.Add(prop[0], prop[1]);
            }

            var result = new User()
            {
                FirstName = pairs["firstName"],
                LastName = pairs["lastName"],
                Age = int.Parse(pairs["age"])
            };

            return result;
        }

    }
}
