using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DataType(DataType.Currency)]
        public int Salary { get; set; }
        public Gender gender { get; set; }
        
        public int? FK_DeptId { get; set; }
        [ForeignKey("FK_DeptId")]
        public virtual Department department { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
    public enum Gender
    {
        Male,
        Female
    }
}