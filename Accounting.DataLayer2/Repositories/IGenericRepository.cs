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
        IEnumerable<TEntity> GetAll();
      
       Task< TEntity> GetById(int id);

        Task<bool> Create(TEntity entity);

        Task<TEntity> Update(int id, TEntity entity);


        Task<TEntity> Delete(int id);
        Task<TEntity> Delet(TEntity entity);
        Task save();
        Task<bool> ExistsID(int id);
    }

}
