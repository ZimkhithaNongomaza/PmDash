using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;
    

namespace PmDash.Controllers
{
    public class AdminWildController:Controller
    {

        private IWildCoast repository;
        public AdminWildController(IWildCoast repo)
        {
            repository = repo;

        }
        public ViewResult Index() => View(repository.WildCoasts);
        public ViewResult Edit(int investorId) =>
           View(repository.WildCoasts.FirstOrDefault(i => i.InvestorID == investorId));
        [HttpPost]
        public IActionResult Edit(WildCoast wildCoast)
        {
            if (ModelState.IsValid)
            {
                repository.SaveWidCoast(wildCoast);
                TempData["message"] = $"{wildCoast.Name} has been approved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the datavalues
                return View(wildCoast);
            }
        }
        public ViewResult Create() => View("Edit", new WildCoast());
        [HttpPost]
        public IActionResult Delete(int investorID)
        {
            WildCoast deleteWild = repository.DeleteWild(investorID);
            if (deleteWild != null)
            {
                TempData["message"] = $"{deleteWild.Name} has been deleted";
            }
            return RedirectToAction("Index");

        }
    }
}
