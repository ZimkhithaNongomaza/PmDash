using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public interface IDocument
    {
        IQueryable<Document> Documents { get; }
        void SaveDocument(Document document);
        Document DeleteDocument(int documentID);




    }
}
