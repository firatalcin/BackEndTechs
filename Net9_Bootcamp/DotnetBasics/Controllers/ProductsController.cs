using DotnetBasics.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBasics.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            string[] kurslar = { "Javascript Kursu", "React Kursu", "Angular Kursu" };
            return View(kurslar);
        }

        public ActionResult List()
        {
            List<Product> urunler = new List<Product>
            {
                new Product {
                    urunBaslik = "IPhone 15", urunFiyat= 80000, urunResim="i1.png", urunAciklama="Güzel telefon", urunSatistami=true
                },
                new Product {
                    urunBaslik = "IPhone 16", urunFiyat= 90000, urunResim="i2.png", urunAciklama="Güzel telefon", urunSatistami=true
                },
                new Product {
                    urunBaslik = "IPhone 17", urunFiyat= 95000, urunResim="i3.png", urunAciklama="Güzel telefon", urunSatistami=false
                },
            };

            return View(urunler);
        }
        
        
        public ActionResult Details()
        {
            Product urun1 = new Product()
            {
                urunBaslik = "Samsung S24 Ultra",
                urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah",
                urunFiyat = 70000,
                urunResim = "samsung-s24.jpg",
                urunSatistami = false,
                StokAdeti = 10
            };

            return View(urun1);
        }

    }
}
