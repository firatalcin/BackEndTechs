using Microsoft.AspNetCore.Mvc;

namespace DotnetBasics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            //int urunFiyat = 5000;
            
            sayi1 = 30;
            sayi2 = 40;
            
            int  sonuc = sayi1 + sayi2;
            
            ViewData["sonuc"] = sonuc;
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        
        public ActionResult Contact()
        {
            return View();
        }
    }
}
