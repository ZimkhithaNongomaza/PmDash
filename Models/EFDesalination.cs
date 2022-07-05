using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class EFDesalination:IDesalination
    {
        private ApplicationDbContext context;
        public EFDesalination(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Desalination> Desalinations => context.Desalinations;
        public void SaveDesalination(Desalination desalination)
        {
            if (desalination.InvestorID == 0)
            {
                context.Desalinations.Add(desalination);
            }
            else
            {
                Desalination dbEntry = context.Desalinations
                    .FirstOrDefault(p => p.InvestorID == desalination.InvestorID);
                if (dbEntry != null)
                {
                    dbEntry.Name = desalination.Name;
                    dbEntry.Asset = desalination.Asset;
                    dbEntry.Comments = desalination.Comments;
                    dbEntry.DateToBeSigned = desalination.DateToBeSigned;
                    dbEntry.InvestmentValue = desalination.InvestmentValue;
                    dbEntry.Lease = desalination.Lease;
                    dbEntry.Status = desalination.Status;
                    dbEntry.TeamMembers = desalination.TeamMembers;
                }
            }
            context.SaveChanges();
        }
        public Desalination DeleteDesalination(int desalinationID)
        {
            Desalination dbEntry = context.Desalinations
                .FirstOrDefault(p => p.InvestorID == desalinationID);
            if (dbEntry != null)
            {
                context.Desalinations.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
