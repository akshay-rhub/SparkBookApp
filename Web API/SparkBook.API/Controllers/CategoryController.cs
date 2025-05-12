using BusinessLogic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SparkBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryBusiness _category;
        public CategoryController(ICategoryBusiness category)
        {
            _category = category;
        }
        [HttpGet]
        public IActionResult getCategory() 
        {
            var catagories = _category.GetCategories();
            return Ok(catagories);
        }
    }
}
