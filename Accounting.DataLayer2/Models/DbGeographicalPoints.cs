using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Accounting.DataLayer2.Models
{
    public class DbGeographicalPoints
    {
  

       
        //[Key]
        public int ID { get; set; }
       public int JPersen { get; set; }
        public double Lat1 { get; set; }
        public double Lon1 { get; set; }
        public double Lat2 { get; set; }
        public double Lon2 { get; set; }
        public double Gpoint { get; set; }
     
        public virtual Persen Persen { get; set; }
      
    }
}
