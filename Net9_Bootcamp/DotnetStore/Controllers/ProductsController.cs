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

        public ActionResult List(string url)
        {
            var urunler = _context.Products.Where(i => i.IsActive && i.Category.Url == url).ToList();
            return View(urunler);
        }

        public ActionResult Details(int id)
        {
            var urun =  _context.Products.Find(id);

            if (urun == null)
            {
                return RedirectToAction("List");
            }
            
            ViewData["BenzerUrunler"] = _context.Products
                .Where(i => i.IsActive && i.CategoryId == urun.CategoryId && i.Id != id)
                .Take(4)
                .ToList();
            
            
            return View(urun);
        }

    }
}
