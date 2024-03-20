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
        public string GetFavSongs() 
        {
            if (FavoriteSongs == null || FavoriteSongs.Count == 0)
            {
                return $"This person ->{FirstName}<- hates music!!!";
            }
            string favoriteSongs ="";
            foreach (Song song in FavoriteSongs)
            {
                favoriteSongs += $"{song.Title}\n" ;
            }
            
            return $"{FirstName} favorite genre is: {FavoriteMusicType} and favorite songs are: \n{favoriteSongs}";
        }
            
        }
    }

