using Task2.Models;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Songs
            List<Song> songs = new List<Song>()
            {   new Song(){
                    Title = "Zidareva Ljubav",
                    Length = 2.30M,
                    Genre = Genre.Classical
               },
               new Song()
               {
                   Title = "Hit em up",
                   Length = 3.2M,
                   Genre = Genre.HipHop
               },
               new Song()
               {
                   Title = "Starlight",
                   Length = 2.3M,
                   Genre= Genre.Rock
               },
               new Song()
               {
                   Title = "Californication",
                   Length = 3.5M,
                   Genre = Genre.Rock
               },
               new Song()
               {
                   Title = "6th Symphony",
                   Length = 5M,
                   Genre = Genre.Classical
               },
               new Song()
               {
                   Title = "3rd Symphony",
                   Length = 6.4M,
                   Genre = Genre.Classical
               },
               new Song()
               {
                   Title = "Chop Suey",
                   Length = 3.7M,
                   Genre = Genre.Rock
               },
               new Song()
               {
                   Title = "Stairway To Heaven",
                   Length = 4.3M,
                   Genre = Genre.Rock
               }
            };

            #endregion

            #region Persons
            List<Person> persons = new List<Person>()
            {
               new Person()
               {
                   Id = 1,
                   FirstName = "Boris",
                   LastName = "Krstovski",
                   Age = 31,
                   FavoriteMusicType = Genre.Rock,
                   FavoriteSongs = new List<Song>()
                   {
                       songs[0],songs[3],songs[6]
                   }

                },
               new Person()
               {
                   Id= 2,
                   FirstName = "Simona",
                   LastName = "Krstovski",
                   Age = 27,
                   FavoriteMusicType = Genre.Classical,
                   FavoriteSongs = new List<Song>()
                   {
                       songs[1],songs[4],songs[5]
                   }
               },
               new Person()
               {
                   Id=3,
                   FirstName = "Alisa",
                   LastName = "Krstovska",
                   Age=7,
                   FavoriteMusicType= Genre.HipHop,
               },
               new Person()
               {
                   Id = 4,
                   FirstName = "Sasho",
                   LastName = "Popovski",
                   Age=20,
                   FavoriteMusicType = Genre.HipHop
               }
            };

            #endregion

            #region CLASS DEMO
            try
            {
                List<Song> classicalSongs = songs.Where(x => x.Genre == Genre.Classical).ToList();
                List<Song> classicalSongsWithLength = songs.Where(x => x.Genre == Genre.Classical && x.Length > 5).ToList();

                List<string> classicalSongsNames = songs.Where(x => x.Genre == Genre.Classical).Select(x => $"{x.Title} ({x.Length}min.)").ToList();

                //Song firstSongThatHasTo = songs.First(x => x.Title.ToLower().Contains("Boris"));
                Song firstOrDefaultSongThatHasTo = songs.FirstOrDefault(x => x.Title.ToLower().Contains("boris"));

                if (firstOrDefaultSongThatHasTo != null)
                    Console.WriteLine(firstOrDefaultSongThatHasTo.Title);

                //Console.WriteLine(firstSongThatHasTo.Title);
                //Console.WriteLine(firstOrDefaultSongThatHasTo.Title);


                List<Song> distinctSongs = songs.DistinctBy(x => x.Title).ToList();

                List<Song> sortByLength = songs.OrderBy(x => x.Length).ToList();

                List<IGrouping<Genre, Song>> groupByType = songs.GroupBy(x => x.Genre).ToList();

            
            #endregion

            List<Song> songsForBoris = songs.Where(x => x.Title.StartsWith("S")).ToList();
            persons[0].FavoriteSongs = songsForBoris;

            List<Song> songsForSimona = songs.Where(x => x.Length > 3).ToList();
            persons[1].FavoriteSongs = songsForSimona;

            List<Song> songsForAlisa = songs.Where(x => x.Genre == Genre.Rock).ToList();
            persons[2].FavoriteSongs = songsForAlisa;

            List<Song> songsForSasho = songs.Where(x => x.Length < 3 && x.Genre == Genre.HipHop).ToList();
            persons[3].FavoriteSongs = songsForSasho;

            List<Person> result = persons.Where(x => x.FavoriteSongs.Count >= 4).ToList();



            Console.WriteLine(persons[0].GetFavSongs());
            Console.WriteLine(persons[1].GetFavSongs());
            Console.WriteLine(persons[2].GetFavSongs());
            Console.WriteLine(persons[3].GetFavSongs());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error happened.PLease try again");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Global exception error!!");
            }
            finally
            {
                Console.WriteLine("Thank you for using our app");
            }
        }
    }
}
