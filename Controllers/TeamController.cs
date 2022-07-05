using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Somandla()
        {
            return View();
        }
        public IActionResult Ubuntu()
        {
            return View();
        }
        public IActionResult PowerRangers()
        {
            return View();
        }
        public IActionResult Diversity()
        {
            return View();
        }
    }
}
