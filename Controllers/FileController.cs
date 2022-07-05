using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace PmDash.Controllers
{
    public class FileController:Controller
    {
        private IHostingEnvironment Environment;

        public FileController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(List<IFormFile> postedFiles)
        {
            string wwwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            List<string> UploadedFiles = new List<string>();
            foreach (IFormFile postedfile in postedFiles)
            {
                string fileName = Path.GetFileName(postedfile.FileName);
                using (FileStream stream = new FileStream(Path.Combine(path,fileName), FileMode.Create))
                {
                    postedfile.CopyTo(stream);
                    UploadedFiles.Add(fileName);
                    ViewBag.Message += string.Format("<b>{0}</b> uploaded. <br />", fileName);
                }
            }
            return View();
        }

    }
}
