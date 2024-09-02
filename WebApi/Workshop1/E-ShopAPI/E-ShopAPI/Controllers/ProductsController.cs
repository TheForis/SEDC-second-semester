using E_ShopAPI.DbAccess;
using E_ShopAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ProductDto>> GetAll()
        {
            try
            {
                var productsList = StaticDb.Products.Select(x=> new ProductDto 
                {
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    ImageUrl = x.ImageUrl
                }).ToList();
                return Ok(productsList);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server error, please contact the administrator!");
            }
        }
    }
}
