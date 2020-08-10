
using Accounting.DataLayer.Services;
using Accounting.DataLayer2.Models;
using Accounting.DataLayer2.Repositories;
using Accounting.DataLayer2.Services;
using Castle.Windsor.Diagnostics;
using System;


namespace Accounting.DataLayer2.ContextRepositories
{
    public class UnitOfWork : IDisposable
    {
        ContextDB db = new ContextDB();


       
        private GenericRepository<Persen> _Persen;

        public GenericRepository<Persen> Persen
        {
            get
            {
                if (_Persen == null)
                {
                    _Persen = new GenericRepository<Persen>();
                }

                return _Persen;
            }
        }

        private ISearchPersen _FindPersen;
        public ISearchPersen FindPersen
        {
            get
            {
                if (_FindPersen == null)
                {
                    _FindPersen = new FindPersen();
                }

                return _FindPersen;
            }
        }



        private IPersonnelActivityHistory _personnelActivityHistory;
        public IPersonnelActivityHistory PersonnelHistory
        {
            get
            {
                if (_personnelActivityHistory == null)
                {
                    _personnelActivityHistory = new CPersonnelActivityHistory();
                }

                return _personnelActivityHistory;
            }
        }




        private GenericRepository<DbGeographicalPoints> _dbGeographicalPoints;

        public GenericRepository<DbGeographicalPoints> DbGeographicalPoints
        {
            get
            {
                if (_dbGeographicalPoints == null)
                {
                    _dbGeographicalPoints = new GenericRepository<DbGeographicalPoints>();
                }

                return _dbGeographicalPoints;
            }
        }

   
        public void save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
