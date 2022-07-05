using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PmDash.Models;

namespace PmDash.ViewComponents
{
    public class PocoViewComponent
    {
        private IAqua repository;
        public PocoViewComponent(IAqua repo)
        {
            repository = repo;
        }
        public string Invoke()
        {
            return $"{repository.AquaDevelopments.Count()}";
        }
    }
    
}
