using Accounting.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.DataLayer.Repositories
{
   public interface IPersen<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(Object Id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(Object Id);
        void Save();
    }
}
