using Microsoft.AspNetCore.Mvc;

namespace AngularShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
