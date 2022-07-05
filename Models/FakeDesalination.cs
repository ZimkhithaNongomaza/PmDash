using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class FakeDesalination/*IDesalination*/
    {
        public IQueryable<Desalination> Desalinations => new List<Desalination>
        {
             new Desalination {Name = "Desalination Plant", Lease = "N/A", Asset="building", InvestmentValue=350000000, TeamMembers="MandlaM", Status=" Project not sure" },


        }.AsQueryable<Desalination>();
    }
}
