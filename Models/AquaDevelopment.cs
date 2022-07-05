using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;

namespace PmDash.Models
{
    public class AquaDevelopment
    {
       [Key]
        public int InvestorID { get; set; }
        public string Name { get; set; }
        public string Lease { get; set; }
        public DateTime DateToBeSigned { get; set; }
        public string Asset { get; set; }
        public int InvestmentValue { get; set; }

        public string Comments { get; set; }
        public string TeamMembers { get; set; }

        public string Status { get; set; }
    }
}
