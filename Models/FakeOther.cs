using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class FakeOther/*IOther*/

    {
        public IQueryable<Other> Others => new List<Other>
        {
            new Other {Name = "Whey", Lease = "No", Asset="Building", InvestmentValue=50000000, TeamMembers="JabuM", Status=" Project Appoved By DG Board"}


        }.AsQueryable<Other>();
    }
}
