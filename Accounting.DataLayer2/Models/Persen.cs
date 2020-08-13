using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Accounting.DataLayer2.Models
{
    public class Persen
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Persen()
        //{
        //    this.DbGeographicalPoints = new HashSet<DbGeographicalPoints>();
           
        //}
        //[ForeignKey("DbGeographicalPoints")]
        public int ID { get; set; }
        //[Required(ErrorMessage = "{0} is required")]
        //[StringLength(50, MinimumLength = 3,
        // ErrorMessage = " Name should be minimum 3 characters and a maximum of 50 characters")]
        //[DataType(DataType.Text)]
        public string Name { get; set; }
        //[DataType(DataType.EmailAddress)]
        //[EmailAddress]
        public string Email { get; set; }
        //[Required]
        //[StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        public string Password { get; set; }
        
        public ICollection<DbGeographicalPoints> DbGeographicalPoints { get; set; }
    }
}
