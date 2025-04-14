using DotnetStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ProductsController
        public ActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }

    }
}
