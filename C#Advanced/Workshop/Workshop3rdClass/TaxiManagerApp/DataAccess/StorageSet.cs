using Models;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace DataAccess
{
    public class StorageSet<T> : IStorageSet<T> where T : BaseEntity
    {
        //public List<T> Items { get; set; } = new List<T>();

        public void Add(T entity)
        {
            var items = ReadItems();
            if(entity.Id != 0)
            {
                throw new Exception("For adding new item, the Id needs to be set to 0");
            }

            if (items.Any())
            {
                int max = items.Max(x => x.Id);
                entity.Id = max + 1;
            }
            else
            {
                entity.Id = 1;
            }

            items.Add(entity);
            SaveItems(items);
        }

        public List<T> GetAll()
        {
            return ReadItems();
        }

        public T GetById(int id)
        {
            var items = ReadItems();
            T item = items.FirstOrDefault(x => x.Id == id);

            if(item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {id} does not exit");
            }

            return item;
        }

        public void Update(T entity)
        {
            var items = ReadItems();
            T item = items.FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {entity.Id} does not exit");
            }

            int index = items.IndexOf(item);

            items[index] = entity;
            SaveItems(items);
        }

        public void Delete(T entity)
        {
            Delete(entity.Id);
        }

        public void Delete(int id)
        {
            var items = ReadItems();
            T item = items.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {id} does not exit");
            }

            items.Remove(item);
            SaveItems(items);
        }
        private List<T> ReadItems()
        {
            string folderPath = @"..\..\..\Data";
            string fileName = $"{typeof(T).Name}s.json";
            string filePath = $@"{folderPath}\{fileName}";
            var result = new List<T>();

            if (!Directory.Exists(folderPath) || !File.Exists(filePath))
            {
                return result;
            }
            try
            {
                using (var sr = new StreamReader(filePath))
                {
                    string content = sr.ReadToEnd();
                    result = JsonConvert.DeserializeObject<List<T>>(content)?? new List<T>();
                }
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
        private void SaveItems(List<T> items)
        {
            string folderPath = @"..\..\..\Data";
            string fileName = $"{typeof(T).Name}s.json";
            string filePath = $@"{folderPath}\{fileName}";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            string content = JsonConvert.SerializeObject(items);

            using(var sw = new StreamWriter(filePath))
            {
                sw.WriteLine(content);
            }
        }
    }
}


