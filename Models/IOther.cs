using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public interface IOther
    {
        IQueryable<Other> Others { get; }
        void SaveOther(Other other);
        Other DeleteOther(int otherID);
    }
}
