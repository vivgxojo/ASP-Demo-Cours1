using cours1.Models;
using cours1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace cours1.Controllers
{
    public class EtudiantController : Controller
    {
        public List<Etudiant> lstEtudiants = Groupe.Etudiants;
        public IActionResult Index()
        {
            //ViewBag.ListeEtudiants = lstEtudiants;
            //return View("Liste", lstEtudiants);

            Classe classe = new Classe();
            classe.Etudiants = lstEtudiants;
            classe.Cours = "ASP.Net";
            classe.Enseignant = "Maryse";
            return View("Classe", classe);

        }
        public IActionResult Find(int id)
        {
            ViewBag.EtudiantId = id;
            Etudiant e = lstEtudiants.FirstOrDefault(e => e.NumeroEtudiant == id);
            if (e != null)
            {
                //ViewBag.Nom = e.Nom;
                return View("Etudiant", e);
            }
            return View("Error");
        }
    }
}
