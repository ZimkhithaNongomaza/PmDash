using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class EFAqua:IAqua
    {
        private ApplicationDbContext context;
        public EFAqua(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<AquaDevelopment> AquaDevelopments => context.AquaDevelopments;
        public void SaveAqua(AquaDevelopment aquaDevelopment)
        {
            if(aquaDevelopment.InvestorID==0)
            {
                context.AquaDevelopments.Add(aquaDevelopment);
            }
            else
            {
                AquaDevelopment dbEntry = context.AquaDevelopments
                    .FirstOrDefault(p => p.InvestorID == aquaDevelopment.InvestorID);
                if (dbEntry!=null)
                {
                    dbEntry.Name = aquaDevelopment.Name;
                    dbEntry.Asset = aquaDevelopment.Asset;
                    dbEntry.Comments = aquaDevelopment.Comments;
                    dbEntry.DateToBeSigned = aquaDevelopment.DateToBeSigned;
                    dbEntry.InvestmentValue = aquaDevelopment.InvestmentValue;
                    dbEntry.Lease = aquaDevelopment.Lease;
                    dbEntry.Status = aquaDevelopment.Status;
                    dbEntry.TeamMembers = aquaDevelopment.TeamMembers;
                }
            }
            context.SaveChanges();
        }
        public AquaDevelopment DeleteAqua(int aquaID)
        {
            AquaDevelopment dbEntry = context.AquaDevelopments
                .FirstOrDefault(p => p.InvestorID == aquaID);
            if(dbEntry != null)
            {
                context.AquaDevelopments.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
