using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QinshiftNotesDemoAppAndTags.Db;
using QinshiftNotesDemoAppAndTags.Models;

namespace QinshiftNotesDemoAppAndTags.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(StaticDb.Users);
        }
        [HttpGet("byId/{id:int}")]
        public ActionResult<string> GetById(int id)
        {
            if (id != 0 && id > 0)
            {
                return Ok(StaticDb.Users[id - 1]);
            }
            return BadRequest("Id must have positive value different than zero!");
        }
        [HttpGet("byName/{name:alpha}")]
        public ActionResult<string> GetByName(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                var result = (StaticDb.Users.FirstOrDefault(x => x.ToLower() == name.ToLower()));
                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest("Name not found");
            }
            return BadRequest("Name not found");

        }
        [HttpGet("queryString")]
        public ActionResult<string> GetByIdFromQuery(int index)
        {
            if(index != 0 && index > 0) {
                return Ok(StaticDb.Users[index - 1]);

            }
            return BadRequest("Id must have positive value");
        }
        [HttpPost("fromBody")]
        public IActionResult AddUserFromBody([FromBody]User user) 
        {
            return Ok("Added successfully");
        }

        [HttpPost("fromQuery")]
        public IActionResult AddUserFromQuery([FromQuery] User user)
        {
            return Ok();
        }
        [HttpPost("headerInfo")]
        public IActionResult headerInfo([FromHeader(Name = "Accept-Language")] string language, [FromHeader(Name = "Custom-Name")] string name)
        {
            return Ok(language + name);
        }

    }
}
