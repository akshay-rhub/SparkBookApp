using Microsoft.AspNetCore.Mvc;

namespace SparkBook.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
