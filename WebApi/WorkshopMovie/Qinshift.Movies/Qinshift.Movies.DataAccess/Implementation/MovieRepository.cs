using Qinshift.Movies.DataAccess.Interface;
using Qinshift.Movies.DomainModels;

namespace Qinshift.Movies.DataAccess.Implementation
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _movieDb;

        public MovieRepository(MovieDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void CreateMovie(Movie movie)
        {
            _movieDb.Movies.Add(movie);
            _movieDb.SaveChanges();
        }

        

        public List<Movie> GetAll()
        {
            var result = _movieDb.Movies.ToList();
            return result;
        }

        public Movie GetById(int id)
        {
            Movie result = _movieDb.Movies.SingleOrDefault(x => x.Id == id);
            return result;
        }

        public void UpdateMovie(Movie movie)
        {
            var updateMovie = GetById(movie.Id);
            if (updateMovie != null)
            {
                _movieDb.Movies.Update(movie);
            }
            else
            {
                throw new Exception($"No movie found with id [{movie}]");
            }
            
        }
        public void DeleteMovie(Movie movie)
        {
            _movieDb.Movies.Remove(movie);
        }
        public void DeleteMovieById(int id)
        {
            var movieToDelete = GetById(id);
            DeleteMovie(movieToDelete);
        }
    }
}
