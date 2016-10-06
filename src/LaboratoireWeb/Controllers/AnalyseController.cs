using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaboratoireData.Models;
using LaboratoireMetier;
using LaboratoireData;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LaboratoireWeb.Controllers
{
    public class AnalyseController : Controller
    {
        private IAnalyseur _analyseur;
        private ILaboratoireRepository _repository;

        public AnalyseController(IAnalyseur analyseur, ILaboratoireRepository repository)
        {
            if (analyseur == null)
                throw new ArgumentNullException("analyseur");

            if (repository == null)
                throw new ArgumentNullException("repository");

            _analyseur = analyseur;

            _repository = repository;
        }

        [HttpPost]
        public IActionResult Analyse(Echantillon echantillon)
        {
            IAnalyse analyse = _analyseur.Demarrer(echantillon);
            _repository.InsertAnalyse(analyse);
            _repository.Save();

            return View(analyse);
        }

        [HttpGet]
        public IActionResult Analyse()
        {
            ViewData["Message"] = "Saisissez la couleur de l'échantillon.";

            return View("Echantillon");
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Message"] = "Liste des Analyses.";
            IEnumerable <IAnalyse> analyses = _repository.GetAnalyses();

            return View(analyses);
        }
    }
}
