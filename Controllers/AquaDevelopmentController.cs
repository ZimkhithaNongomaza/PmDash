using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;

namespace PmDash.Controllers
{
    public class AquaDevelopmentController:Controller
    {
        private IAqua repository;
        public AquaDevelopmentController(IAqua repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.AquaDevelopments);

    }
}
