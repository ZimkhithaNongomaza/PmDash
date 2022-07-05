using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public interface  IInvestor
    {
        IQueryable<Investor> Investors { get; }
        void SaveInvestor(Investor investor);
        Investor DeleteInvestor(int investorID);


    }
}
