using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DTOs;

namespace Qinshift.Movies.Services.Helper
{
    public static class MovieMapper
    {
        public static MovieDto MapToDto(Movie movie)
        {
            var result = new MovieDto()
            {
                Title = movie.Title,
                Plot = movie.Plot,
                ReleaseDate = movie.ReleaseDate.ToString("dd-MM-yyyy"),
                Genre = movie.Genre.ToString()

            };
            return result;
        }
        public static Movie MapToMovie(CreateMovieDto movie)
        {
            var result = new Movie()
            {
                Title = movie.Title,
                Plot = movie.Plot,
                ReleaseDate = movie.ReleaseDate,
                Genre = (GenreEnum)movie.Genre
            };
            return result;
        }
    }
}
