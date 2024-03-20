namespace Task2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        public List<Song> GetFavSongs() 
        {
            if (FavoriteSongs == null)
            {
                Console.WriteLine("This person hates music!!!");
                return null;
            }
            return FavoriteSongs;
        }
    }
}
