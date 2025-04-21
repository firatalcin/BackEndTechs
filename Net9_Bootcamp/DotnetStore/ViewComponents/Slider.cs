using DotnetStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetStore.ViewComponents;

public class Slider : ViewComponent
{
    private readonly AppDbContext _context;

    public Slider(AppDbContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        return View(_context.Sliders.ToList());
    }
}