using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Labs.Day2.EmployeeForm.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(128)]
        public string Email { get; set; }
        [Range(2000,50000)]
        public int Salary { get; set; }
        public Gender gender { get; set; }


    }
    public enum Gender
    {
        Male,
        Female
    }
}