using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public class EFDocument : IDocument
    {
        private ApplicationDbContext context;
        public EFDocument(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Document> Documents => context.Documents;
        public void SaveDocument(Document document)
        {
            if (document.DocumentID == 0)
            {
                context.Documents.Add(document);
            }
            else
            {
                Document dbEntry = context.Documents
                    .FirstOrDefault(p => p.DocumentID == document.DocumentID);
                if (dbEntry != null)
                {
                    dbEntry.Name = document.Name;
                    dbEntry.Category = document.Category;
                    dbEntry.Pdd = document.Pdd;
                    dbEntry.BSA = document.BSA;
                    dbEntry.Eq = document.Eq;
                    dbEntry.FundingApproval = document.FundingApproval;
                    dbEntry.Investment = document.Investment;
                    dbEntry.FeesAgreement = document.FeesAgreement;
                    dbEntry.Prc = document.Prc;
                    dbEntry.Rmc = document.Rmc;
                    dbEntry.Frc = document.Frc;
                    dbEntry.Exma = document.Exma;
                    dbEntry.Converted = document.Converted;

                }
            }
            context.SaveChanges();
        }
        public Document DeleteDocument(int documentID)
        {
            Document dbEntry = context.Documents
                .FirstOrDefault(p => p.DocumentID == documentID);
            if (dbEntry != null)
            {
                context.Documents.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
