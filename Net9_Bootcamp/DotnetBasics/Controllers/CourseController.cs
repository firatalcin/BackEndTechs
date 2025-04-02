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
            // string kursAdi1 = "Javascript Kursu";
            // string kursAdi2 = "React Kursu";

            // string kursAciklama1 = "Javascript Kurs Açıklaması";
            // string kursAciklama2 = "React Kurs Açıklaması";

            string[] kursAdlari = ["Javascript Kursu", "React Kursu"];
            string[] kursAciklamalari = ["Javascript Kurs Açıklaması", "React Kurs Açıklaması"];
            string[] kursResimleri = ["1.jpg", "2.jpg"];

            ViewData["kursAdi1"] = kursAdlari[0]; // Javascript Kursu
            ViewData["kursAdi2"] = kursAdlari[1]; // React Kursu

            ViewData["kursAciklama1"] = kursAciklamalari[0]; // Javascript Kurs Açıklaması
            ViewData["kursAciklama2"] = kursAciklamalari[1]; // React Kurs Açıklaması

            ViewData["kursResim1"] = kursResimleri[0]; // 1.jpg
            ViewData["kursResim2"] = kursResimleri[1]; // 2.jpg

            // ViewData["kursAdlari"] = kursAdlari;
            // ViewData["kursAciklamalari"] = kursAciklamalari;
            // ViewData["kursResimleri"] = kursResimleri;
            // @(((string[])ViewData["kursAdlari"])[0])

            return View();
            
            return View();
        }
        
        
        public ActionResult Details()
        {
            return View();
        }
    }
}
