using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class FakeWild/*IWildCoast*/
    {
        public IQueryable<WildCoast> WildCoasts => new List<WildCoast>
        {
            new WildCoast {Name = "AAP Industries", Lease = "No", Asset="building", InvestmentValue=380000000, TeamMembers="SimphiweS", Status=" Project not sure" },


        }.AsQueryable<WildCoast>();
    }
}
