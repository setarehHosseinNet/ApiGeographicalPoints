using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.ViewModels;

namespace Accounting.DataLayer.Services
{
    public class DepotRepository : IDepotRepository
    {
        Accounting_DBEntities db;

        public DepotRepository(Accounting_DBEntities context)
        {
            db = context;
        }
        public List<Depot> GetAllDepot()
        {
            return db.Depot.ToList();
        }

        public IEnumerable<Depot> GetDepotsFiliter(string prometr)
        {
            return db.Depot.Where(c => c.DepotName.Contains(prometr) || c.DepotSubject.Contains(prometr)).ToList();
        }


        public Depot GetDepotById(int depotID)
        {
            return db.Depot.Find(depotID);
        }

        public bool InsertDepot(Depot depot)
        {
            try
            {
                db.Depot.Add(depot);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDepot(Depot depot)
        {
            try
            {

                var local = db.Set<Depot>()
                    .Local
                    .FirstOrDefault(f => f.DepotID == depot.DepotID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }


                db.Entry(depot).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDepot(Depot depot)
        {
            try
            {
                db.Entry(depot).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDepot(int DepotID)
        {
            try
            {
                var depot = GetDepotById(DepotID);
                DeleteDepot(depot);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DepotNameViewModel> GetDepotName(string filiter = "")
        {
            if (filiter == "")
            {
                return db.Depot.Select(c => new DepotNameViewModel()
                {
                    DepotName = c.DepotName,
                    DpotId = c.DepotID
                }).ToList();


            }
            return db.Depot.Where(c => c.DepotName.Contains(filiter)).Select(c => new DepotNameViewModel()
            {
                DepotName = c.DepotName,
                DpotId = c.DepotID
            }).ToList();
        }

        public List<float> GetMojodi(int filiter = 0)
        {
            if (filiter==0)
            {
                return db.Mojodi2.Select(c => c.Mojodi.Value).ToList();
            }
            else
            {
                return db.Mojodi2.Where(c => c.Jmatril==filiter).Select(c => c.Mojodi.Value).ToList();
            }
        }

        public int EndID()
        {
            return int.Parse(db.Havaleh2.Max(c => c.HID2).ToString());
        }

        public int EndNumbeHalah()
        {
            return int.Parse(db.Havaleh2.Max(c => c.NumberHavaleh).ToString());
        }
    }
}
