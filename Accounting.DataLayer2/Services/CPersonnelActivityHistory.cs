using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            var _persen = db.Persen.Find(persen);
            return db.DbGeographicalPoints.Where(c => c.Persen == _persen);
        }
    }
}
