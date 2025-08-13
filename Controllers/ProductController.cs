using Microsoft.AspNetCore.Mvc;

namespace souq.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
