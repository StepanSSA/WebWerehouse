using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Abstract;
using WebWerehouse.Domains;

namespace WebWerehouse.Controllers
{
    public class ChemistryController : Controller
    {
        private readonly IProductCRUDRepository _repo;

        public ChemistryController(IProductCRUDRepository repo)
        {
            _repo = repo;
        }

        public IActionResult TableChemistry()
        {
            return View(_repo.Chemistres);
        }

        public IActionResult Edit(long Id)
        {
            var сhemistry = _repo
                .Chemistres
                .FirstOrDefault(p => p.Id == Id);

            if (сhemistry == null) return View("Error");

            return View(сhemistry);
        }

        [HttpPost]
        public IActionResult Edit(Сhemistry сhemistry)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(сhemistry);
                return RedirectToAction("Index", "Home");
            }
                

            return RedirectToAction("Error");
        }

        public IActionResult Create()
        {
            var Chemistry = new Сhemistry();
            return View(Chemistry);
        }

        [HttpPost]
        public IActionResult Create(Сhemistry сhemistry)
        {
            if (ModelState.IsValid)
            {
                _repo.Create(сhemistry);
                return RedirectToAction("Index","Home");
            }
            return View("Error");
        }
    }
}
