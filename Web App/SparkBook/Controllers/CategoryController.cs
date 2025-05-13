using BusinessLogic.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SparkBook.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategory _category;
        public readonly ILogger<CategoryController> _logger;
        public CategoryController(ICategory category, ILogger<CategoryController> logger)
        {
            _category = category;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                _logger.LogInformation($"Getting all categories Categories ");
                var categories = await _category.GetCategories();
                return View(categories);
            }
            catch (Exception ex) 
            {
                _logger.LogInformation($"Categories not found {ex.Message}");
                return View();
            }
        }
    }
}
