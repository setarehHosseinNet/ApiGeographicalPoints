using System;
using System.Collections.Generic;
using System.Text;
using Accounting.DataLayer2;
using Accounting.DataLayer2.ContextRepositories;
using Accounting.DataLayer2.Models;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Internal;
using NHibernate.Util;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Business2
{
    public  class Account
    {
        public string name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }


        public async Task<IEnumerable<Persen>> GetPersen()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return await Task.Run(()=>{ return db.Persen.GetAll(); });
            }
        }

        public async Task<Persen> GetPersen( int id)
        {

            using (UnitOfWork db = new UnitOfWork())
            {


                var persen = await db.Persen.GetById(id);

                return persen;
            }
        }
        public async Task<bool> PutPersen( int id, Persen persen)
        {


            using (UnitOfWork db = new UnitOfWork())
            {

                var res = await db.Persen.Update(id, persen);

                try
                {
                    await db.save();
                    return true;
                }
                catch (DbUpdateConcurrencyException)
                {
                    return false;
                }

               
            }
        }

        public async Task<Persen> PostPersen( Persen persen)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                await db.Persen.Create(persen);
                await db.save();

                return persen;
            }
        }

        public async Task<Persen> DeletePersen( int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {



                //var persen = await _context.Persen.FindAsync(id);
                //if (persen == null)
                //{
                //    return NotFound();
                //}

                var del =await db.Persen.Delete(id);
                await db.save();

                return del;
            }
        }

        public async Task<bool> PersenExistsID(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return await db.Persen.ExistsID(id);
            }
        }
        public async Task<string> Login(Persen persen)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
             
                if (await db.FindPersen.FindAccount(persen.Email,persen.Password) == "null")
                {
                    return "null";
                }
                else
                {
                  return await  db.FindPersen.FindAccount(persen.Email, persen.Password);
                }
            }
        }


    }
}
