using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PmDash.Models
{
    public class Desalination
    {
        [Key]
        public int InvestorID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Lease { get; set; }
     
        public DateTime DateToBeSigned { get; set; }
        public string Asset { get; set; }  
        [Display(Name="Investment Value")]
        public int InvestmentValue { get; set; }

        public string Comments { get; set; }
        [Display(Name="Team Members")]
        public string TeamMembers { get; set; }

        public string Status { get; set; }
    }
}
