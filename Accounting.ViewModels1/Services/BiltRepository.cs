using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Accounting.DataLayer.Services
{
    public class BiltRepository : IBiltRepository
    {
        Accounting_DBEntities db;
        private DbSet<Zaiat> _dbSet;

        public BiltRepository(Accounting_DBEntities context)
        {
            db = context;
           
            _dbSet = db.Set<Zaiat>();
        }
        public IEnumerable<Zaiat> GetOrderBY(Expression<Func<Zaiat, bool>> where=null )
        {
            IQueryable<Zaiat> query =_dbSet;
            if (where != null)
            {
                query = query.OrderBy(where);
            }

            return query.ToList();
        }
    }
}
