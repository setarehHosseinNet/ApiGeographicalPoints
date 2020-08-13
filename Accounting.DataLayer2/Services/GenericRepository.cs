using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;
using System.Threading.Tasks;
using NHibernate.Mapping;

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

        public virtual async Task<TEntity> Delete(int id)
        {
          
                var entity =await GetById(id);
                await Delet(entity);
                return entity;
          
           
        }
        public virtual async Task<TEntity> Delet(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
                {
                     _dbSet.Attach(entity);
                }

                _dbSet.Remove(entity);
                return entity;
            
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            IEnumerable<TEntity> query = _dbSet;
          
            return (IEnumerable<TEntity>)query.ToList();
        }

        public virtual async Task<TEntity>  GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<TEntity> Update(int id, TEntity entity)
        {
          
                _dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
                return entity;
           
        }

        public async Task save()
        {
          await  _db.SaveChangesAsync();
        }

        public async Task<bool> ExistsID(int id)
        {
            var res = await _dbSet.FindAsync(id);
            if (res == null)
            {
                return false;
            }
            else
                return true;
        }
    }
}
