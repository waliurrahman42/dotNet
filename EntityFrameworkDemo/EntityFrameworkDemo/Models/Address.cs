using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo.Models
{
    public class Address
    {
        public int Id { get; set; }
        
       // [Required]
        public string AddressLine { get; set; }
        
     //   [Required(ErrorMessage ="City Name is Mandatory")]
        public String City { get; set; }
       
        public ICollection<Student> Students { get; set; }

    }
}