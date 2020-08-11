using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;
using System.Threading.Tasks;

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
        public virtual async Task<bool> Create(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
            
        }

        public virtual async Task<bool> Delete(int id)
        {
            try
            {
                var entity =await GetById(id);
                await Delet(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
        public virtual async Task<bool> Delet(TEntity entity)
        {
            try
            {
                if (_db.Entry(entity).State == EntityState.Detached)
                {
                     _dbSet.Attach(entity);
                }

                _dbSet.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
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

        public virtual async Task<TEntity>  GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Update(int id, TEntity entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }





    }
}
