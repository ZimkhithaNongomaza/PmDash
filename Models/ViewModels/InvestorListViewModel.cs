using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PmDash.Models;

namespace PmDash.Models.ViewModels
{
    public class InvestorListViewModel
    {
        public IEnumerable<Investor> Investors { get; set; }
        public IEnumerable<Document> Documents { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
