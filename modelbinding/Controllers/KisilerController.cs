using Microsoft.AspNetCore.Mvc;
using modelbinding.Models;

namespace modelbinding.Controllers
{
    public class KisilerController : Controller
    {
        static List<Kisi> kisiler = new List<Kisi>() {  // burada normalde static yerine veritabanindan cekiyoruz
        
            new Kisi() { Ad = "Ali"},
            new Kisi() { Ad = "Ece"},
            new Kisi() { Ad = "Can"},
            new Kisi() { Ad = "Ela"},
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Yeni()
        {
            return View();
        }
    }
}
