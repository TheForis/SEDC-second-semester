using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NotesAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        //[Route("all-books")]
        public List<string> Get()
        {
            return new List<string> { "book1", "book2", "Book3" };
        }
        [HttpGet("info")]
        public string GetInfo()
        {
            return "This is some info about the book store!";
        }
        //[HttpGet]
        //public string GetString()
        //{
        //    return "test";
        //}
        [HttpGet("details/{id}")]
        public string GetById(int id)
        {
            return $"Book with Id: {id}";
        }

        [HttpGet("details/{id}/author/{authorId}")]
        public string GetBookAuthorDetails(int id,int authorId)
        {
            return $"Book with id: {id}, is written by author id: {authorId}";
        }
    }
}
