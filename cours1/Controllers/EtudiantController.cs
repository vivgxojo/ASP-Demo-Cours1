using cours1.Models;
using Microsoft.AspNetCore.Mvc;

namespace cours1.Controllers
{
    public class EtudiantController : Controller
    {
        public List<Etudiant> lstEtudiants = Groupe.Etudiants;
        public IActionResult Index()
        {
            ViewBag.ListeEtudiants = lstEtudiants;
            return View();
        }
        public IActionResult Find(int id)
        {
            ViewBag.EtudiantId = id;
            Etudiant e = lstEtudiants.FirstOrDefault(e => e.NumeroEtudiant == id);
            if (e != null)
            {
                ViewBag.Nom = e.Nom;
                return View();
            }
            return View("Error");
        }
    }
}
