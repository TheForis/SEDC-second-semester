using Models;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace Storage
{
    public class SetStorage
    {
        
        
        public void ReadUsers()
        {
            string folderPath = @"..\..\..\Data";
            string filePath = $@"{folderPath}\users.json";
            var listResult = new List<BaseUser>();
            

            using(var sr = new StreamReader(filePath))
            {
                var result = JsonConvert.DeserializeObject(filePath);
            }

        }
        public void SaveUsers()
        {
            string folderPath = @"..\..\..\Data";
            string filePath = $@"{folderPath}\users.json";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }
    }
}
