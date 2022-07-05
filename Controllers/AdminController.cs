using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;

namespace PmDash.Controllers
{
    public class AdminController:Controller
    {
        private IInvestor repository;
        public AdminController(IInvestor repo)
        {
            repository = repo;

        }
        public ViewResult Index() => View(repository.Investors);
        public ViewResult Edit(int investorId) =>
           View(repository.Investors.FirstOrDefault(i => i.InvestorID == investorId));
        [HttpPost]
        public IActionResult Edit(Investor investor)
        {
            if (ModelState.IsValid)
            {
                repository.SaveInvestor(investor);
                TempData["message"] = $"{investor.Name} has been approved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the datavalues
                return View(investor);
            }
        }
        public ViewResult Create() => View("Edit", new Investor());
        [HttpPost]
        public IActionResult Delete(int investorID)
        {
            Investor deleteInvestor = repository.DeleteInvestor(investorID);
            if (deleteInvestor != null)
            {
                TempData["message"] = $"{deleteInvestor.Name} has been deleted";
            }
            return RedirectToAction("Index");

        }
    }
}
