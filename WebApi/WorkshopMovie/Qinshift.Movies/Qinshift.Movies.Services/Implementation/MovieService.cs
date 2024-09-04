using Qinshift.Movies.DTOs;
using Qinshift.Movies.Services.Interface;
using Qinshift.Movies.Services.Helper;
using Qinshift.Movies.DataAccess.Interface;

namespace Qinshift.Movies.Services.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<MovieDto> GetAllMovies()
        {
            var movies = _movieRepository.GetAll();
            var moviesResult = movies.Select(x =>
                
            MovieMapper.MapToDto(x)).ToList();
                
            return moviesResult;
        }
        public MovieDto GetById(int id)
        {
            var movieResult = _movieRepository.GetById(id);
            if (movieResult != null)
            {
                return MovieMapper.MapToDto(movieResult);
            }
            return null;
        }

        public MovieDto GetMovieByGenre()
        {
            throw new NotImplementedException();
        }

        public MovieDto GetMovieByYear()
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(int id,CreateMovieDto movie)
        {
            var movieToEdit = _movieRepository.GetById(id);
            if (movieToEdit == null) throw new Exception("Movie not found!");

            var mappedMovie = MovieMapper.MapToMovie(movie);
            _movieRepository.UpdateMovie(id, mappedMovie);
        }
        public void CreateMovie(CreateMovieDto movie)
        {
            var mappedMovie = MovieMapper.MapToMovie(movie);
            _movieRepository.CreateMovie(mappedMovie);
        }

        public void DeleteMovie(int id)
        {
            var movieToDelete = _movieRepository.GetById(id);
            if (movieToDelete != null)
            {
                _movieRepository.DeleteMovie(movieToDelete);
            }
            else
            {
                throw new Exception($"Movie with id {id} does not exist!");
            }
        }
    }
}
