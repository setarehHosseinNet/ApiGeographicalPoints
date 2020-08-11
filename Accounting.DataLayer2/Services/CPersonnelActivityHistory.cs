using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer2.Services
{
   public class CPersonnelActivityHistory : IPersonnelActivityHistory
    {
        ContextDB db;

        public CPersonnelActivityHistory()
        {
            db = new ContextDB();
        }
        

        public IEnumerable<DbGeographicalPoints> History(int persen)
        {
            return db.DbGeographicalPoints.Include(c => c.Persen).Where(c => c.Persen.ID == persen);
        }
    }
}
