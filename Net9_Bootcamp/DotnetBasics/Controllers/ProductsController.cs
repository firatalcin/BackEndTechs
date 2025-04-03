using DotnetBasics.Models;
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
            Product urun1 = new Product();

            urun1.urunBaslik = "Samsung S24 Ultra";
            urun1.urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah";
            urun1.urunFiyat = 70000;
            urun1.urunResim = "samsung-s24.jpg";
            urun1.urunSatistami = false;

            return View(urun1);
        }

    }
}
