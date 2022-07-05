using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class EFOther:IOther
    {
        private ApplicationDbContext context;
        public EFOther(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Other> Others => context.Others;
        public void SaveOther(Other other)
        {
            if (other.InvestorID == 0)
            {
                context.Others.Add(other);
            }
            else
            {
                Other dbEntry = context.Others
                    .FirstOrDefault(p => p.InvestorID == other.InvestorID);
                if (dbEntry != null)
                {
                    dbEntry.Name = other.Name;
                    dbEntry.Asset = other.Asset;
                    dbEntry.Comments = other.Comments;
                    dbEntry.DateToBeSigned = other.DateToBeSigned;
                    dbEntry.InvestmentValue = other.InvestmentValue;
                    dbEntry.Lease = other.Lease;
                    dbEntry.Status = other.Status;
                    dbEntry.TeamMembers = other.TeamMembers;
                }
            }
            context.SaveChanges();
        }
        public Other DeleteOther(int OtherID)
        {
            Other dbEntry = context.Others
                .FirstOrDefault(p => p.InvestorID == OtherID);
            if (dbEntry != null)
            {
                context.Others.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }


    }
}
