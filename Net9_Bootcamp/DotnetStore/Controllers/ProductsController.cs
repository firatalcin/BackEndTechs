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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var urunler = _context.Products.ToList();
            return View(urunler);
        }

    }
}
