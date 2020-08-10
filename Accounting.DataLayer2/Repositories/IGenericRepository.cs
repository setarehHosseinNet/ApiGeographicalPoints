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
      
        TEntity GetById(int id);

        void Create(TEntity entity);

        void Update(int id, TEntity entity);
      

        void Delete(int id);
        void Delet(TEntity entity);
        
    }

}
