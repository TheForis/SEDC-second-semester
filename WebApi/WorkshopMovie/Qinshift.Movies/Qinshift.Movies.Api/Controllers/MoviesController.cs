using Microsoft.AspNetCore.Mvc;
using Qinshift.Movies.DTOs;
using Qinshift.Movies.DTOs.Enums;
using Qinshift.Movies.Services.Interface;

namespace Qinshift.Movies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<MovieDto>> GetAll()
        {
            try
            {
                var result = _movieService.GetAllMovies();
                if (result.Count > 0)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound("There are no movies in the library!");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetById/{id:int}")]
        public ActionResult<MovieDto> GetById([FromRoute] int id)
        {
            try
            {
                var result = _movieService.GetById(id);
                if (result == null)
                {
                    return NotFound($"There is no movie with id: {id}"!);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetById")]
        public ActionResult<MovieDto> GetByIdQuery([FromQuery] int id)
        {
            try
            {
                var result = _movieService.GetById(id);
                if (result == null)
                {
                    return NotFound($"There is no movie with id: {id}!");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("CreateNewMovie")]
        public IActionResult CreateNewMovie(string title, DateTime releaseDate, int genre, string? plot)
        {
            try
            {
                if (string.IsNullOrEmpty(title) || releaseDate == null || genre < 1 || genre > 11)
                {
                    return BadRequest("Title, release date and genre are required parametars!");
                }
                var movieResult = new CreateMovieDto()
                {
                    Title = title,
                    Plot = plot,
                    ReleaseDate = releaseDate,
                    Genre = (GenreDto)genre
                };
                _movieService.CreateMovie(movieResult);
                return Ok("Movie Created");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("/EditMovieId/{id:int}")]
        public IActionResult UpdateMovie(int id, [FromBody] CreateMovieDto movie) 
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest("The id must be a positive integer!");
                }
                if (string.IsNullOrEmpty(movie.Title) || movie.ReleaseDate == null || movie.Genre == null)
                {
                    return BadRequest("You must provide the Title, Release date and genre for the movie!");
                }
                _movieService.UpdateMovie(id, movie);
                return Ok("Movie successfully updated!");
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteMovieById/{id:int}")]
        public IActionResult DeleteMovie(int id) 
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest("The id must be a positive integer!");
                }
                _movieService.DeleteMovie(id);
                return Ok("Movie deleted!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
