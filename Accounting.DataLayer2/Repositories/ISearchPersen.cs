using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer2.Repositories
{
   public  interface ISearchPersen
    {
        Task<int> FindPersenLog(string Persen);
        Task<int> FindEmail(string Email);
        Task<int> FindAccount(string User, string password);
        Task<int> LengthPersen();
    }
}
