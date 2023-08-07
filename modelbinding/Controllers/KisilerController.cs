using Microsoft.AspNetCore.Mvc;
using modelbinding.Models;

namespace modelbinding.Controllers
{
    //[Route("Kisiler")] dersek localhost:5000/Kisiler/Abidik yazinca bu controller calisir
    public class KisilerController : Controller
    {
        static List<Kisi> kisiler = new List<Kisi>() {  // burada normalde static yerine veritabanindan cekiyoruz
        
            new Kisi() { Ad = "Ali"},
            new Kisi() { Ad = "Ece"},
            new Kisi() { Ad = "Can"},
            new Kisi() { Ad = "Ela"},
        };

        //[Route("Abidik")] dersek localhost:5000/Abidik yazinca bu action calisir
        // Get: Kisiler
        public IActionResult Index()
        {
            return View(kisiler);
        }
        // Get: Kisiler/Yeni
        public IActionResult Yeni()
        {
            return View();
        }
        // Post: Kisiler/Yeni
        [HttpPost] // post islemlerini buna yonlendiriyor
        public IActionResult Yeni(Kisi kisi)
        {
            // burada ne yapacagiz tekrardan ayni view verisini dondurmemeliyiz
            if (ModelState.IsValid)
            {
                kisiler.Add(kisi);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
