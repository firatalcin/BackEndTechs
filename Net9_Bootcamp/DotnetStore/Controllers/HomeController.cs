using Microsoft.AspNetCore.Mvc;
using DotnetStore.Models;

namespace DotnetStore.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var urunler = _context.Products.Where(product => product.IsActive && product.MainPage).ToList();
        ViewData["Categories"] = _context.Categories.ToList();
        return View(urunler);
    }
}