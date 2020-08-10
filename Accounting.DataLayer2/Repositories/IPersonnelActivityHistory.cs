using Accounting.DataLayer2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.DataLayer2.Repositories
{
   public interface IPersonnelActivityHistory
    {
        IEnumerable<DbGeographicalPoints> History(int persen);
    }
}
