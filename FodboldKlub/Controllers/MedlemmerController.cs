using FodboldKlub.Models;
using FodboldKlub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FodboldKlub.Controllers
{
    public class MedlemmerController : Controller
    {
        private readonly IMedlemRepository _medlemRepository;

        public MedlemmerController(IMedlemRepository medlemRepo)
        {
            _medlemRepository = medlemRepo;
        }


        public IActionResult Index(string sorterEfter = "efternavn")
        {
            var medlemmer = _medlemRepository.HentAlle();

            medlemmer = sorterEfter switch
            {
                "fornavn" => medlemmer.OrderBy(m => m.Fornavn),
                "efternavn" => medlemmer.OrderBy(m => m.Efternavn),
                "adresse" => medlemmer.OrderBy(m => m.Adresse),
                "telefon" => medlemmer.OrderBy(m => m.Telefon),
                "email" => medlemmer.OrderBy(m => m.Email),
                _ => medlemmer.OrderBy(m => m.Adresse)
            };

            return View(medlemmer);
        }

        [HttpGet]
        public IActionResult Opret()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Opret(Medlem medlem)
        {
            if(!ModelState.IsValid)
            {
                return View(medlem);
            }

            _medlemRepository.Tilføj(medlem);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Rediger(Guid id)
        {
            var medlem = _medlemRepository.HentMedID(id);
            if(medlem == null)
            {
                return NotFound();
            }

            return View(medlem);
        }

        [HttpPost]
        public IActionResult Rediger(Guid id, Medlem medlem)
        {
            if(!ModelState.IsValid)
            {
                return View(medlem);
            }

            _medlemRepository.Opdater(medlem);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Slet(Guid id)
        {
            var medlem = _medlemRepository.HentMedID(id);

            if(medlem == null)
            {
                return NotFound();
            }

            return View(medlem);
        }

        [HttpPost]
        public IActionResult Slet(Guid id, Medlem medlem)
        {
            _medlemRepository.Slet(id);
            return RedirectToAction("Index");
        }
    }
}
