using Accounting.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Accounting.DataLayer.Context;
using System.Linq;
using System.Web;
using static Accounting.DataLayer.Models.Context;

namespace Accounting.DataLayer.Services
{
    public class Persen<T> : IPersen<T> where T : class
    {
        private ContextDb db;
        private DbSet<T> dbSet;
        public Persen()
        {
            db = new ContextDb();
            dbSet = db.Set<T>();
        }
        public void Delete(object Id)
        {
            T getObjById = dbSet.Find(Id);
            dbSet.Remove(getObjById);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }
    }
}
