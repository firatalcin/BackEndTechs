using Microsoft.AspNetCore.Mvc;

namespace DotnetBasics.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
        
        
        public ActionResult Details()
        {
            string urunBaslik = "Samsung S24 Ultra";
            string urunAciklama = "Samsung S24 Ultra 512 GB 12 GB RAM";
            double urunFiyat = 69999.99;
            string urunResim = "samsung.jpg";
            bool urunSatistami = false;
            
            ViewData["urunResim"] = urunResim;
            ViewData["urunBaslik"] = urunBaslik;
            ViewData["urunAciklama"] = urunAciklama;
            ViewData["urunFiyat"] = urunFiyat;
            ViewData["urunSatistami"] = urunSatistami;
            
            return View();
        }

    }
}
