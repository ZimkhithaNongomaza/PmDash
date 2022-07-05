using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PmDash.Models;

namespace PmDash.ViewComponents
{
    public class OtherViewComponent
    {
        private IOther repository;
        public OtherViewComponent(IOther repo)
        {
            repository = repo;
        }
        public string Invoke()
        {
            return $"{repository.Others.Count()}";
        }
    }
}
