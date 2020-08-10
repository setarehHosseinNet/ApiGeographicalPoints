using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Accounting.DataLayer.Models
{
    public class DbGeographicalPoints
    {
        public DbGeographicalPoints()
        {
            this.Persen = new HashSet<Persen>();
        }
        [Key]
        public int ID { get; set; }
        public float Lat1 { get; set; }
        public float Lon1 { get; set; }
        public float Lat2 { get; set; }
        public float Lon2 { get; set; }
        public float Gpoint { get; set; }
        public virtual ICollection<Persen> Persen { get; set; }
      
    }
}
