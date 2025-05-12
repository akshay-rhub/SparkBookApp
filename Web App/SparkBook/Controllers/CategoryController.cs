using BusinessLogic.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SparkBook.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _category.GetCategories();
            return View();
        }
    }
}
