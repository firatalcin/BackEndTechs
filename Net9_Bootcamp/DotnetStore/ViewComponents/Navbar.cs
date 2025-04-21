using DotnetStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetStore.ViewComponents;

public class Navbar : ViewComponent
{
    private readonly AppDbContext _context;

    public Navbar(AppDbContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        return View(_context.Categories.ToList());
    }
}