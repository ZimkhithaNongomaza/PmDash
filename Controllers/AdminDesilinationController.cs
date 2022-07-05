using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;
using PmDash.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;

using Microsoft.AspNetCore.Authorization;


namespace PmDash.Controllers
{
    public class AdminDesilinationController:Controller
    {
        private IDesalination repository;
        public AdminDesilinationController(IDesalination repo)
        {
            repository = repo;

        }
        public ViewResult Index() => View(repository.Desalinations);

        public ViewResult Edit(int investorId) =>
            View(repository.Desalinations
                .FirstOrDefault(i => i.InvestorID == investorId));
        [HttpPost]
        public IActionResult Edit(Desalination desalination)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDesalination(desalination);
                TempData["message"] = $"{desalination.Name} has been approved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the datavalues
                return View(desalination);
            }
        }
        public ViewResult Create() => View("Edit", new Desalination());
        [HttpPost]
        public IActionResult Delete(int investorID)
        {
            Desalination deleteDesalination = repository.DeleteDesalination(investorID);
            if (deleteDesalination != null)
            {
                TempData["message"] = $"{deleteDesalination.Name} has been deleted";
            }
            return RedirectToAction("Index");

        }
    }
}
