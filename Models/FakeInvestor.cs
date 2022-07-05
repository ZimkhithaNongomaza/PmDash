using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class FakeInvestor /*IInvestor*/
    {
        public IQueryable<Investor> Investors => new List<Investor>
        {
            new Investor {Name = "Thapi Aqua-Kulture", Lease = "No", Asset="building", InvestmentValue=50000000, TeamMembers="MandlaM", Status=" Project Appoved", Category="Aquaculture Development Zone" },
            new Investor {Name = "Bay Agriculture", Lease = "Mybe", Asset="Land", InvestmentValue=70000000, TeamMembers="MandlaM", Status=" Project Appoved", Category="Aquaculture Development Zone"},
             new Investor {Name = "Desalination Plant", Lease = "N/A", Asset="building", InvestmentValue=350000000, TeamMembers="MandlaM", Status=" Project not sure", Category="Desalination" },
            new Investor {Name = "AAP Industries", Lease = "No", Asset="building", InvestmentValue=380000000, TeamMembers="SimphiweS", Status=" Project not sure", Category="Wild Coast Sez" },
            new Investor {Name = "Whey", Lease = "No", Asset="Building", InvestmentValue=50000000, TeamMembers="JabuM", Status=" Project Appoved By DG Board", Category="Other"}

        
        }.AsQueryable<Investor>();
    }}

