using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;


namespace PmDash.Controllers
{
    public class AdminOtherController:Controller
    {
        private IOther repository;
        public AdminOtherController(IOther repo)
        {
            repository = repo;

        }
        public ViewResult Index() => View(repository.Others);
        public ViewResult Edit(int investorId) =>
           View(repository.Others.FirstOrDefault(i => i.InvestorID == investorId));
        [HttpPost]
        public IActionResult Edit(Other other)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOther(other);
                TempData["message"] = $"{other.Name} has been approved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the datavalues
                return View(other);
            }
        }
        public ViewResult Create() => View("Edit", new Other());
        [HttpPost]
        public IActionResult Delete(int investorID)
        {
            Other deleteOther = repository.DeleteOther(investorID);
            if (deleteOther != null)
            {
                TempData["message"] = $"{deleteOther.Name} has been deleted";
            }
            return RedirectToAction("Index");

        }

    }
}
