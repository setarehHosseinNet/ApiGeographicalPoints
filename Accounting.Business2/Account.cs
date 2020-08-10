using System;
using System.Collections.Generic;
using System.Text;
using Accounting.DataLayer2;
using Accounting.DataLayer2.ContextRepositories;
using Accounting.DataLayer2.Models;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Internal;
using NHibernate.Util;

namespace Accounting.Business2
{
    public  class Account
    {
        public string name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public  void    CreateAccount(string _name,string _email,string _password)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                SHA256CryptoServiceProvider Sha2 = new SHA256CryptoServiceProvider();
             
               
       
                Persen newPersen = new Persen()
                {
                    Name = _name,
                    Email = _email,
                    //Password = UTF8Encoding.UTF8.GetBytes(_password.Trim()).ToString()
                    Password=_password 
                };
                db.Persen.Create(newPersen);
                db.save();
                db.Dispose();
            }

        }
        public int Login(string _email, string _password)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
             
                if (db.FindPersen.FindAccount(_email, _password) == 0)
                {
                    return 0;
                }
                else
                {
                  return  db.FindPersen.FindAccount(_email, _password);
                }
            }
        }


    }
}
