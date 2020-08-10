using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;

using System.Linq.Dynamic.Core;


namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private ContextDB _db;
        private DbSet<TEntity> _dbSet;
        public GenericRepository()
        {
            _db = new ContextDB();
            _dbSet = _db.Set<TEntity>();
        }
        public virtual void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            Delet(entity);
        }
        public virtual void Delet(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }
        public virtual IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }

            return (IQueryable<TEntity>)query.ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Update(int id, TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }





    }
}
