using _3rdClassHomework.Db;
using _3rdClassHomework.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace _3rdClassHomework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeveragesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Beverage>> Get() 
        {
            return Ok(StaticDb.Beverages);
        }
        [HttpGet("index/{index:int}")]
        public ActionResult<Beverage> GetByIndex([FromQuery]int index)
        {
            try
            {
                if(index < StaticDb.Beverages.Count && index > 0)
                {
                    return Ok(StaticDb.Beverages[index - 1]);
                }
                else if (index < 0) return BadRequest("The index must be a positive number");
                else return NotFound($"There is no beverage with index {index}");

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error occured, please contant the administrator");
            }
        }
        [HttpGet("filterQuery")]
        public ActionResult<Beverage> FilterByBrandAndType([FromQuery] string brand, [FromQuery] string type) 
        {
            try
            {
                if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(type))
                    return BadRequest("Filter paramteres are required!");
                var result = StaticDb.Beverages.FirstOrDefault(x => x.Brand.ToLower().Contains(brand.ToLower()) && x.Type.ToLower().Contains(type.ToLower()));
                if (result == null) return BadRequest($"There is no beverage from [{brand}] and type [{type}]");
                else return Ok(result);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error occured, please contant the administrator");
            }
        }
        [HttpPost("addBeverage")]
        public IActionResult AddBeverageFromBody([FromBody] Beverage beverage)
        {
            try
            {
                if (string.IsNullOrEmpty(beverage.Brand) || string.IsNullOrEmpty(beverage.Type))
                    return BadRequest("both paramteres are required!");
                else if (StaticDb.Beverages.Where(x => x.Brand.ToLower() == beverage.Brand.ToLower() && x.Type.ToLower() == beverage.Type.ToLower()).Any()) return BadRequest($"The brand [{beverage.Brand} and type [{beverage.Type}] already exists! ");
                else
                {
                    StaticDb.Beverages.Add(beverage);
                    return Ok($"The beverage from brand [{beverage.Brand}] type [{beverage.Type}] has been added successfully!");

                }
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error occured, please contant the administrator");
            }
        }
        [HttpPost("addMultipleBeverages")]
        public IActionResult AddMultipleBeverages([FromBody] List<Beverage> beverages)
        {
            try
            {
                foreach (var beverage in beverages)
                {
                    if (StaticDb.Beverages.Where(x => x.Brand.ToLower() == beverage.Brand.ToLower() && x.Type.ToLower() == beverage.Type.ToLower()).Any()) { continue; }
                    else
                    {
                        StaticDb.Beverages.Add(beverage);
                    }
                }
                return Ok($"Beverages that were not present already were added to the list!");
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error occured, please contant the administrator");
            }
        }

    }
}
