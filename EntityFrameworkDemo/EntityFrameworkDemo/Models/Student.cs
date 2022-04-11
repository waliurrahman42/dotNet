using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Models
{
    public class Student
    {

        public int StudentId { get; set; }//scaler property

        [Required]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
       // public string Email { get; set; }

        public Address Address { get; set; } //navigation property
    }

   
}