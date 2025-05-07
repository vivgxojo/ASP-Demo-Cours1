using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cours1.Controllers;
using cours1.Models;
using cours1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ProjetTestsDemo
{
    public class TestsControllerEtudiant
    {
        [Fact]
        public void TestIndex()
        {
            EtudiantController etudiantController = new EtudiantController();
            var result = etudiantController.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.Model);
            var model = Assert.IsType<Classe>(viewResult.Model);
            Assert.Equal("Maryse", model.Enseignant);
            Assert.Equal("ASP.Net", model.Cours);
        }
        [Fact]
        public void TestFind()
        {
            EtudiantController etudiantController = new EtudiantController();
            var result = etudiantController.Find(1);
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(1, viewResult.ViewData["EtudiantId"]);
            var model = Assert.IsType<Etudiant>(viewResult.Model);
            Assert.Equal("Alex", model.Nom);
            Assert.Equal(1, model.NumeroEtudiant);
        }
        [Fact]
        public void TestNotFind()
        {
            EtudiantController etudiantController = new EtudiantController();
            var error = etudiantController.Find(-1);
            var viewResult1 = Assert.IsType<ViewResult>(error);
            Assert.Null(viewResult1.Model);
        }

    }
}
