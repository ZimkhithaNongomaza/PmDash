using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PmDash.Models;
using PmDash.Models.ViewModels;


namespace PmDash.Controllers
{
    public class InvestorController:Controller
    {
        private IInvestor repository;
        public int PageSize = 4;

        public InvestorController(IInvestor repo)
        {
            repository = repo;
        }
        public ViewResult List(string category,int investorPage = 1)
          => View(new InvestorListViewModel
          {
              Investors=repository.Investors
              .Where(i =>category ==null || i.Category==category)
                            .OrderBy(i => i.InvestorID)
              .Skip((investorPage - 1) * PageSize)
             .Take(PageSize),
              PagingInfo = new PagingInfo
              {
                  CurrentPage = investorPage,
                  ItemsPerPage = PageSize,
                  TotalItems = repository.Investors.Count()
              },
              CurrentCategory=category

          }

                    );
    }
}
