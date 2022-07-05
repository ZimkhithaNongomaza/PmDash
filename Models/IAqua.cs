using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
   public  interface IAqua
    {
        IQueryable<AquaDevelopment> AquaDevelopments { get; }
        void SaveAqua(AquaDevelopment aquaDevelopment);
        AquaDevelopment DeleteAqua(int aquaID);
       
    }
}
