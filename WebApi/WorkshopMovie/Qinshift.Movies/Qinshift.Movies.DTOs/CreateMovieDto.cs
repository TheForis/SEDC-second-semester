using Qinshift.Movies.DTOs.Enums;

namespace Qinshift.Movies.DTOs
{
    public class CreateMovieDto
    {
        public string Title { get; set; }
        public string? Plot { get; set; }
        public DateTime  ReleaseDate { get; set; }
        public GenreDto Genre { get; set; }
    }
}
