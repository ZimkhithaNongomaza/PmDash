using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;

namespace PmDash.Controllers
{
    public class WildCoastController:Controller
    {
        private IWildCoast repository;
        public WildCoastController(IWildCoast repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.WildCoasts);
    }
}
