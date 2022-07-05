using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class FakeDocument/*IDocument*/
    {
        public IQueryable<Document> Documents => new List<Document>
        {
            new Document{Name = "Thapi Aqua-Kulture", Pdd= "Yes",BSA="No", Eq = "No", FundingApproval = "No", Investment=0,FeesAgreement="No", Prc="No", Rmc="No",Frc="No",Exma="No",Converted="No"},
          new Document{Name = "Bay Aquaculture", Pdd= "No",BSA="Yes", Eq = "No", FundingApproval = "No", Investment=0,FeesAgreement="No", Prc="No", Rmc="No",Frc="No",Exma="No",Converted="No"},
          new Document{Name = "AAP Industries", Pdd= "No",BSA="Yes", Eq = "Yes", FundingApproval = "No", Investment=0,FeesAgreement="No", Prc="No", Rmc="No",Frc="No",Exma="No", Converted="No"},
          new Document{Name = "Whey", Pdd= "Pdd-Yes",BSA="Yes", Eq ="Yes" , FundingApproval ="Yes" , Investment=125000000,FeesAgreement="Yes", Prc="Yes", Rmc="Yes",Frc="Yes",Exma="No",Converted="No"},

        }.AsQueryable<Document>();



    }
}
