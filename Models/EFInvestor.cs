using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class EFInvestor:IInvestor
    {
        private ApplicationDbContext context;
        public EFInvestor(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Investor> Investors => context.Investors;
        public void SaveInvestor(Investor investor)
        {
            if (investor.InvestorID == 0)
            {
                context.Investors.Add(investor);
            }
            else
            {
                Investor dbEntry = context.Investors
                    .FirstOrDefault(p => p.InvestorID == investor.InvestorID);
                if (dbEntry != null)
                {
                    dbEntry.Name = investor.Name;
                    dbEntry.Asset = investor.Asset;
                    dbEntry.Comments = investor.Comments;
                    dbEntry.DateToBeSigned = investor.DateToBeSigned;
                    dbEntry.InvestmentValue = investor.InvestmentValue;
                    dbEntry.Lease = investor.Lease;
                    dbEntry.Status = investor.Status;
                    dbEntry.TeamMembers = investor.TeamMembers;
                    dbEntry.Category = investor.Category;

                }
            }
            context.SaveChanges();
        }
        public Investor DeleteInvestor(int investorID)
        {
            Investor dbEntry = context.Investors
                .FirstOrDefault(p => p.InvestorID == investorID);
            if (dbEntry != null)
            {
                context.Investors.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
