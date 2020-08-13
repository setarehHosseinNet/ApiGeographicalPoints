using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


using System.Linq;
using System.Threading.Tasks;

namespace Accounting.DataLayer2.Services
{
  public  class FindPersen : ISearchPersen
    {
        ContextDB db;

        public FindPersen()
        {
            db =new ContextDB();
        }
        public async Task<string> FindAccount(string User, string password)
        {
            var id=await (db.Persen.Where(c => c.Email.Contains(User) || c.Name.Contains(User) && c.Password.Contains(password)).AnyAsync()) ? db.Persen.Single(c => c.Email.Contains(User) || c.Name.Contains(User) && c.Password.Contains(password)).Name : "null";
            return id;

        }

        public async Task<int> FindEmail(string Email)
        {
            return await (db.Persen.Where(c => c.Email.Contains(Email)).AnyAsync()) ? db.Persen.Single(c => c.Email.Contains(Email)).ID : 0;
        }

        public async Task<int> LengthPersen()
        {
            return await db.Persen.CountAsync();
        }

      

      public async  Task<int> FindPersenLog(string Persen)
        {
            return await(db.Persen.Where(c => c.Name.Contains(Persen)).AnyAsync()) ? db.Persen.Single(c => c.Name.Contains(Persen)).ID : 0;
        }
    }
}
