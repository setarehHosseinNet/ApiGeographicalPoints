using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer2.Repositories
{
    public interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null);
      
       Task< TEntity> GetById(int id);

        Task<bool> Create(TEntity entity);

        Task<bool> Update(int id, TEntity entity);


        Task<bool> Delete(int id);
        Task<bool> Delet(TEntity entity);
        
    }

}
