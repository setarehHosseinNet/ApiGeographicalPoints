using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;

using System.Linq;


namespace Accounting.DataLayer2.Services
{
  public  class FindPersen : ISearchPersen
    {
        ContextDB db;

        public FindPersen()
        {
            db =new ContextDB();
        }
        public int FindAccount(string User, string password)
        {
            var id= (db.Persen.Where(c => c.Email.Contains(User) || c.Name.Contains(User) && c.Password.Contains(password)).Any()) ? db.Persen.Single(c => c.Email.Contains(User) || c.Name.Contains(User) && c.Password.Contains(password)).ID : 0;
            return id;

        }

        public int FindEmail(string Email)
        {
            return (db.Persen.Where(c => c.Email.Contains(Email)).Any()) ? db.Persen.Single(c => c.Email.Contains(Email)).ID : 0;
        }

        public int LengthPersen()
        {
            return db.Persen.Count();
        }

        int ISearchPersen.FindPersen(string Persen)
        {
            return (db.Persen.Where(c => c.Name.Contains(Persen)).Any()) ? db.Persen.Single(c => c.Name.Contains(Persen)).ID : 0;
        }
    }
}
