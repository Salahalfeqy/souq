using Microsoft.AspNetCore.Mvc;
using souq.Models;

namespace souq.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductVm model )
        {

            if (ModelState.IsValid)
            {
                Souq2Context db = new Souq2Context();
                Category c = new Category();
                c.Name = model.CatName;
                //db.Categories.Add(c);
                db.Products.Add(new Product
                {
                    Name = model.ProductName,
                    Price = model.ProductPrice,
                    Quantity = model.ProductQty,

                    Cat = c
                });
                db.SaveChanges();
                return View("Index");
            }
            return View("Index" , model);
        }
    }
}
