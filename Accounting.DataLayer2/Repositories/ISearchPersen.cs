using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;


namespace Accounting.DataLayer2.Repositories
{
   public  interface ISearchPersen
    {
        int FindPersen(string Persen);
        int FindEmail(string Email);
        int FindAccount(string User, string password);
        int LengthPersen();
    }
}
