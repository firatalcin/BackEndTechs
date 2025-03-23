using Microsoft.AspNetCore.Mvc;

namespace DotnetBasics.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string List()
        {
            return "List";
        }
    }
}
