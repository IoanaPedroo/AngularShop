using Microsoft.AspNetCore.Mvc;

namespace AngularShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
