using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PmDash.Models;

namespace PmDash.ViewComponents
{
    public class WildViewComponent
    {
        private IWildCoast repository;
        public WildViewComponent(IWildCoast repo)
        {
            repository = repo;
        }
        public string Invoke()
        {
            return $"{repository.WildCoasts.Count()}";
        }
    }
}
