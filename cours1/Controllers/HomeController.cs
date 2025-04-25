using Microsoft.AspNetCore.Mvc;

namespace cours1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Affiche la vue Index
        }
        public IActionResult Hello(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return View("Error");
            }
            ViewBag.Nom = id; //ViewData["Nom"]
            return View();
        }

        public IActionResult Privacy()
        {
            string texte = "On vole toutes vos données";
            return Content(texte);
        }
    }
}
