using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PmDash.Models;

namespace PmDash.ViewComponents
{
    public class DesViewComponent
    {
        private IDesalination repository;
        public DesViewComponent(IDesalination repo)
        {
            repository = repo;
        }
        public string Invoke()
        {
            return $"{repository.Desalinations.Count()}";
        }
    }
}
