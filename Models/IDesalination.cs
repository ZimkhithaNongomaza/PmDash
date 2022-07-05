using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PmDash.Models
{
    public interface IDesalination
    {
        IQueryable<Desalination> Desalinations { get; }
        void SaveDesalination(Desalination desalination);
        Desalination DeleteDesalination(int desalinationID);

    }
}
