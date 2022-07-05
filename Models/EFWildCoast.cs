using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class EFWildCoast:IWildCoast
    {
        private ApplicationDbContext context;
        public EFWildCoast(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<WildCoast> WildCoasts => context.WildCoasts;
        public void SaveWidCoast(WildCoast wildCoast)
        {
            if (wildCoast.InvestorID == 0)
            {
                context.WildCoasts.Add(wildCoast);
            }
            else
            {
                WildCoast dbEntry = context.WildCoasts
                    .FirstOrDefault(p => p.InvestorID == wildCoast.InvestorID);
                if (dbEntry != null)
                {
                    dbEntry.Name = wildCoast.Name;
                    dbEntry.Asset = wildCoast.Asset;
                    dbEntry.Comments = wildCoast.Comments;
                    dbEntry.DateToBeSigned = wildCoast.DateToBeSigned;
                    dbEntry.InvestmentValue = wildCoast.InvestmentValue;
                    dbEntry.Lease = wildCoast.Lease;
                    dbEntry.Status = wildCoast.Status;
                    dbEntry.TeamMembers = wildCoast.TeamMembers;
                }
            }
            context.SaveChanges();
        }
        public WildCoast DeleteWild(int wildID)
        {
            WildCoast dbEntry = context.WildCoasts
                .FirstOrDefault(p => p.InvestorID == wildID);
            if (dbEntry != null)
            {
                context.WildCoasts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
