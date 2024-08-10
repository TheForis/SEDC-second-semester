using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QinshiftNotesDemoAppAndTags.Db;
using QinshiftNotesDemoAppAndTags.Models;

namespace QinshiftNotesDemoAppAndTags.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Note>> Get()
        {
            try
            {
                return Ok(StaticDb.Notes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server not working");
            }
        }
        [HttpGet("{index}")]
        public ActionResult<Note> GetByIndex(int index)
        {
            try
            {
                if (index < 0) return BadRequest("Index must have positive value");
                if (index > StaticDb.Notes.Count) return NotFound($"Cannot find resource on index {index}");
                return StaticDb.Notes[index - 1];
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server not working");
            }
        }
        [HttpGet("getByQueryString")]
        public ActionResult<Note> GetByQueryString(int index)
        {
            try
            {
                if (index < 0) return BadRequest("Index must have positive value");
                if (index > StaticDb.Notes.Count) return NotFound($"Cannot find resource on index {index}");
                return StaticDb.Notes[index - 1];
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server not working");
            }
        }
        [HttpGet("{text}/priority/{priority}")]
        public ActionResult<List<Note>> FilterNotes (string text, int priority)
        {
            try
            {
                if (string.IsNullOrEmpty(text) || priority <= 0) return BadRequest("Filter parametars are required");
                if (priority > 3) return BadRequest("invalid value for priority");
                var notes = StaticDb.Notes.Where(x => x.Text.ToLower().Contains(text.ToLower()) && (int)x.Priority == priority).ToList();
                return Ok(notes);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server not working");
            }
        }
        [HttpGet("multipleParams")]
        public ActionResult<List<Note>> FilterNotesByMultipleParams(string? text, int? priority)
        {
            try
            {
                if (string.IsNullOrEmpty(text) && priority == null) return BadRequest("YOu have to send at least one parametar!");
                if (string.IsNullOrEmpty(text))
                {
                    var notes = StaticDb.Notes.Where(x => (int)x.Priority == priority).ToList();
                    return Ok(notes);   
                }
                if(priority == null)
                {
                    var notes = StaticDb.Notes.Where(x=> x.Text.ToLower().Contains(text.ToLower())).ToList();
                    return Ok(notes);
                }
                var resultNotes = StaticDb.Notes.Where(x => x.Text.ToLower().Contains(text.ToLower()) && (int)x.Priority == priority).ToList();
                return Ok(resultNotes);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server not working");
            }
        }

    }
}
