using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;
namespace PmDash.Controllers
{
    public class AdminDocController:Controller
    {
        private IDocument repository;
        public AdminDocController(IDocument repo)
        {
            repository = repo;

        }
        public ViewResult Index() => View(repository.Documents);
        public ViewResult Edit(int documentId) =>
           View(repository.Documents.FirstOrDefault(i => i.DocumentID == documentId));
        [HttpPost]
        public IActionResult Edit(Document document)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDocument(document);
                TempData["message"] = $"{document.Name} has been approved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the datavalues
                return View(document);
            }
        }
        public ViewResult Create() => View("Edit", new Document());
        [HttpPost]
        public IActionResult Delete(int documentID)
        {
            Document deleteDoc = repository.DeleteDocument(documentID);
            if (deleteDoc != null)
            {
                TempData["message"] = $"{deleteDoc.Name} has been deleted";
            }
            return RedirectToAction("Index");

        }
    }
}
