using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PmDash.Models
{
    public class Document
    {
        [Key]
        public int DocumentID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Pdd { get; set; }
        public string BSA { get; set; }
        public string Eq
        {
            get; set;
         }
        public string FundingApproval
        {
            get; set;
         }
        public int Investment
        {
            get; set;
     }
        public string FeesAgreement { get; set; }
                
        public string Prc
        {
            get; set;
         }
        public string Rmc
        {
            get; set;
         }
        public string Frc
        {
            get;set;
         }
        public string Exma
        {
            get; set;
         }
        public string Converted
        {
            get; set;
         }

    }
}
