using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Device.Location;
using Accounting.DataLayer2.ContextRepositories;
using Accounting.DataLayer2.Models;

namespace Accounting.Business2
{
    public class PointCoordinates
    {
        public double CalculateTheDistance(double Lat1, double Lon1, double Lat2, double Lon2,int IdPersen)
        {
            var sCoord = new System.Device.Location.GeoCoordinate(Lat1, Lon1);
            var eCoord = new System.Device.Location.GeoCoordinate(Lat2, Lon2);
            var calc = sCoord.GetDistanceTo(eCoord);
            using (UnitOfWork db=new UnitOfWork())
            {
                DbGeographicalPoints newPoint = new DbGeographicalPoints() { 
                Lat1=Lat1,
                Lon1=Lon2,
                Lat2=Lat2,
                Lon2=Lon2,
                Gpoint=calc,
                Persen=db.Persen.GetById(IdPersen)
                };

                db.DbGeographicalPoints.Create(newPoint);
                db.save();
                db.Dispose();
            }
            return calc;
        }
        public IEnumerable<DbGeographicalPoints> PersonnelActivityHistory(int Idperson)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
               
                return db.PersonnelHistory(Idperson);
            }
        }
    }
}
