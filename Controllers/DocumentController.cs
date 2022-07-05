using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PmDash.Models;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models.ViewModels;

namespace PmDash.Controllers
{
    public class DocumentController:Controller
    {
        private IDocument repository;
        public int PageSize = 4;

        public DocumentController(IDocument repo)
        {
            repository = repo;
        }
        public ViewResult List(int documentPage= 1)
           => View(new InvestorListViewModel
           {
               Documents = repository.Documents
                            .OrderBy(i => i.DocumentID)
              .Skip((documentPage - 1) * PageSize)
             .Take(PageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = documentPage,
                   ItemsPerPage = PageSize,
                   TotalItems = repository.Documents.Count()
               }

           }

                    );
    }
}
