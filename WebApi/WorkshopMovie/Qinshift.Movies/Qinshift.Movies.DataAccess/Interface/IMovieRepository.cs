using Qinshift.Movies.DomainModels;

namespace Qinshift.Movies.DataAccess.Interface
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        void CreateMovie(Movie movie);
        void UpdateMovie(int id,Movie movie);
        void DeleteMovieById(int id);
        void DeleteMovie(Movie movie);
    }
}
