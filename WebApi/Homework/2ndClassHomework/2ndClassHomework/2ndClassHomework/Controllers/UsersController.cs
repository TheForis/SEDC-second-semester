using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2ndClassHomework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult <List<User>> Get()
            {
            return Ok(StaticDb.Users);
        }
        [HttpGet("user/{id:int}")]
        public ActionResult<User> Get(int id)
        {
            if (id <= 0) {
                return BadRequest("The id must be positive integer!");
            }
            if (id > StaticDb.Users.Count)
            {
                return StatusCode(StatusCodes.Status404NotFound, $"The user with id {id} does not exist!");
            }
            return Ok(StaticDb.Users[id-1]);
        }
    }
}
