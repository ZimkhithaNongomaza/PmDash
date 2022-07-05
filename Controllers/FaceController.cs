using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PmDash.Controllers
{
    public class FaceController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
