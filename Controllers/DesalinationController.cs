using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;

namespace PmDash.Controllers
{
    public class DesalinationController:Controller
    {
        private IDesalination repository;
        public DesalinationController(IDesalination repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Desalinations);
    }
}
