using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public interface IWildCoast
    {
        IQueryable<WildCoast> WildCoasts { get; }
        void SaveWidCoast(WildCoast wildCoast);
        WildCoast DeleteWild(int wildID);

    }
}
