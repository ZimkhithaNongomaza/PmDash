using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;

namespace PmDash.Controllers
{
    public class OtherController:Controller
    {
        private IOther repository;
        public OtherController(IOther repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Others);
    }
}
