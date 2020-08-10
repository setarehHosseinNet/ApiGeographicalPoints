using Accounting.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface IBiltRepository
    {

        IEnumerable<Persen> GetOrderBY(Expression<Func<Persen, bool>> where = null);
        //IEnumerable<Persen> GetOrderBY(Expression<Func<Persen, bool>> where = null);
    }
}
