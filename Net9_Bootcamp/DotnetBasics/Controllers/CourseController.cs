using DotnetBasics.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBasics.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            List<Course> kurslar = new List<Course> {
                new Course { Title = "Javascript Kursu",Image = "1.jpg" },
                new Course { Title = "React Kursu", Image = "2.jpg" },
                new Course{Title = "Angular Kursu",Image = "3.jpg" }
            };

            return View(kurslar);
        }
        
        
        public ActionResult Details()
        {
            Course kurs1 = new Course();
            kurs1.Title = "Django Kursu";
            kurs1.Image = "1.jpg";

            return View(kurs1);
        }
    }
}
