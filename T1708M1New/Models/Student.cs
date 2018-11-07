using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T1708M1New.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "RollNumber")]
        public string RollNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Status")]
        public StudentStatus Status { get; set; }

        public Student()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Gender = Gender.Other;
            this.Status = StudentStatus.Activated;
        }
    }

   
    public enum StudentStatus
    {
        Activated = 1,
        Deactivated = 0
    }

    public enum Gender
    {
        Male = 1,
        Female = 0,
        Other = 2
    }
}
