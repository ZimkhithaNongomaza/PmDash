using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;



namespace PmDash.Controllers
{
    public class UploadController:Controller
    {
        private readonly string wwwrootDirrectory =
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        public ActionResult Index()
        {
            List<string> images = Directory.GetFiles(wwwrootDirrectory, "*.pdf").Select(Path.GetFileName).ToList();
            return View(images);
            
        }
        [HttpPost]
        public async Task <IActionResult> IndexAsync(IFormFile myFile)
        {
            if(myFile !=null)
            {
                var path = Path.Combine(wwwrootDirrectory, DateTime.Now.Ticks.ToString() + Path.GetExtension(myFile.FileName));

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await myFile.CopyToAsync(stream);
                }
                return RedirectToAction("Index");
            }
            return View();
        }
      public ActionResult Gallery()
        {
            return View();
        }
        
    }

}
