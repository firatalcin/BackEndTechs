using System.Diagnostics;
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
        var urunler = _context.Products.ToList();
        return View(urunler);
    }
}