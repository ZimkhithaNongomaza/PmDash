using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class FakeAqua/*IAqua*/
    {
        public IQueryable<AquaDevelopment> AquaDevelopments => new List<AquaDevelopment>
        {
            new AquaDevelopment {Name = "Thapi Aqua-Kulture", Lease = "No", Asset="building", InvestmentValue=50000000, TeamMembers="MandlaM", Status=" Project Appoved" },
            new AquaDevelopment {Name = "Bay Agriculture", Lease = "Mybe", Asset="Land", InvestmentValue=70000000, TeamMembers="MandlaM", Status=" Project Appoved" }
           

        }.AsQueryable<AquaDevelopment>();
       
        
    }
}
