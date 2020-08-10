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

        IEnumerable<Zaiat> GetOrderBY(Expression<Func<Zaiat, bool>> where = null);
    }
}
