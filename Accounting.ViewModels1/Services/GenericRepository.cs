using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity:class
    {
        private Accounting_DBEntities _db;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

       
        public virtual IEnumerable<TEntity> get(Expression<Func<TEntity,bool>> where=null)
        {
       
               
                IQueryable<TEntity> query = _dbSet;
                if (where != null)
                {
                    query = query.Where(where);
                }

                return query.ToList();
       
            
        }
        public virtual TEntity GetbyID(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

       

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delet(TEntity entity)
        {
            if (_db.Entry(entity).State==EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public virtual void Delet(object id)
        {
            var entity = GetbyID(id);
            Delet(entity);
        }


        public IList<TEntity> GetAllOrder<TKey>( Expression<Func<TEntity, TKey>> sortCondition, Expression<Func<TEntity, bool>> whereCondition=null, bool sortDesc = false)
        {
            if (whereCondition==null)
            {
                IQueryable<TEntity> query = _dbSet;
                if (sortDesc)
                    return query.OrderByDescending(sortCondition).ToList<TEntity>();

                return query.OrderBy(sortCondition).ToList<TEntity>();
            }
            else
            {
                IQueryable<TEntity> query = _dbSet;
                if (sortDesc)
                    return query.Where(whereCondition).OrderByDescending(sortCondition).ToList<TEntity>();

                return query.Where(whereCondition).OrderBy(sortCondition).ToList<TEntity>();
            }
         
        }
    }
}
