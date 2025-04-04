using DotnetBasics.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBasics.Controllers
{
    public class CourseController : Controller
    {
        List<Course> kurslar = new List<Course> {
            new Course { Title = "Javascript Kursu",Image = "1.jpg", IsActive = true, IsHome=true },
            new Course { Title = "React Kursu", Image = "2.jpg", IsActive = true, IsHome=true },
            new Course { Title = "Angular Kursu",Image = "3.jpg", IsActive = true, IsHome=true },
            new Course { Title = "Angular Kursu",Image = "4.jpg", IsActive = true, IsHome=true },
            new Course { Title = "Angular Kursu",Image = "4.jpg", IsActive = true, IsHome=false },
            new Course { Title = "Angular Kursu",Image = "4.jpg", IsActive = true, IsHome=false },
        };
        
        public ActionResult Index()
        {
            return View(kurslar);
        }

        public ActionResult List()
        {
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
