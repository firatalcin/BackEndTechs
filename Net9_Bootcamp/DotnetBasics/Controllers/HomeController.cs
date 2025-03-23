using Microsoft.AspNetCore.Mvc;

namespace DotnetBasics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string About()
        {
            return "About";
        }

    }
}
