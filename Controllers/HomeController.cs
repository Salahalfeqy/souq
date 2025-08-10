using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using souq.Models;

namespace souq.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Souq2Context db = new Souq2Context();

        public IActionResult Index()
        {
            indexVm result = new indexVm();
            //Souq2Context db = new Souq2Context();
            result.Categories = db.Categories.ToList();
            result.Products = db.Products.ToList();
            result.Reviews = db.Reviews.ToList();

            result.LatestProducts = db.Products.OrderByDescending(x => x.EntryDate).Take(4).ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        #region
        public IActionResult Cart()
        {
            return View();
        }


        public IActionResult Category()
        {
            var cats = db.Categories.ToList();
            ViewBag.isAdmin = true;
            return View(cats);
        }


        public IActionResult Products(int id)
        {
            var Products = db.Products.Where(x => x.CatId == id).ToList();
            return View(Products);

        }


        public IActionResult CurrentProduct(int id)
        {
            var Product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(Product);

        }

        [HttpGet]
        public IActionResult ProductSearch(string xname)
        {
            var Products = new List<Product>();
            if (string.IsNullOrEmpty(xname))
            {
                Products = db.Products.ToList();
            }
            else
            {
                Products = db.Products.Where(x => x.Name.Contains(xname)).ToList();

            }
            return View(Products);



        }



        /*[HttpGet]
        public IActionResult SendReview(string Name, string Email, string Subject, string Description)
        {
            SouqContext db = new SouqContext();

            db.Reviews.Add(new Review { Name = Name, Email = Email, Subject = Subject, Description = Description });
            db.SaveChanges();
            return RedirectToAction("Index");

        }*/

        [HttpPost]
        public IActionResult SendReview(Review model)
        {

            db.Reviews.Add(new Review { Name = model.Name, Email = model.Email, Subject = model.Subject, Description = model.Description });
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        #endregion



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
