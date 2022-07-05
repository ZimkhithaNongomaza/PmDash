using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;


namespace PmDash.Controllers
{
    public class AdminAquaController:Controller
    {
        private IAqua repository;
        private ApplicationDbContext context;
    
        public AdminAquaController(IAqua repo)
        {
            repository = repo;

        }
        //public ViewResult Index(string search) => View(repository.AquaDevelopments, 
        //    context.AquaDevelopments.Where(s => s.Name.Contains(search)).ToList());
        public ViewResult Index(string search)
        {
           
            return View(repository.AquaDevelopments);
        }
        public ViewResult Edit(int investorId) =>
            View(repository.AquaDevelopments.FirstOrDefault(i => i.InvestorID == investorId));
        [HttpPost]
        public IActionResult Edit(AquaDevelopment aquaDevelopment)
        {
            if(ModelState.IsValid)
            {
                repository.SaveAqua(aquaDevelopment);
                TempData["message"] = $"{aquaDevelopment.Name} has been approved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the datavalues
                return View(aquaDevelopment);
            }
        }
        public ViewResult Create() => View("Edit", new AquaDevelopment());
        [HttpPost]
        public IActionResult Delete(int investorID)
        {
            AquaDevelopment deleteAqua = repository.DeleteAqua(investorID);
            if (deleteAqua != null)
            {
                TempData["message"] = $"{deleteAqua.Name} has been deleted";
            }
            return RedirectToAction("Index");

        }
        //public ActionResult Index(string search)
        //{
        //    return View(context.AquaDevelopments.Where(s => s.Name.Contains(search)).ToList());
        //}
    }
}
