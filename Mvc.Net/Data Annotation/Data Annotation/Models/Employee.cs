using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data_Annotation.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "ID is Mandatory")]
        public int EmployeeID { get; set; }
        [DisplayName("Name")]
        [Required]
        [StringLength(20,MinimumLength = 5,ErrorMessage = "Name should be in between 5 and 20")]
        public string EmployeeName { get; set; }
        [DisplayName("Age")]
        [Required]
        [Range(20,60)]
        public int? EmployeeAge { get; set; }
        [Required]
        [DisplayName("Gender")]
        public string EmployeeGender { get; set; }
        [DisplayName("Email")]
        [Required]
        [RegularExpression("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])",ErrorMessage = "Invalid Email")]
        public string EmployeeEmail { get; set; }
        [DisplayName("Password")]
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$",ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter and one number")]
        [DataType(DataType.Password)]
        public string EmployeePassword { get; set; }
        [DisplayName("Confirm Password")]
        [Required]
        [Compare("EmployeePassword",ErrorMessage = "Password is not Identical")]
        [DataType(DataType.Password)]
        public string EmployeeConfirmPassword { get; set; }
        [DisplayName("Organization Name")]
        [ReadOnly(true)]
        public string EmployeeOrganization { get; set; }
        [Required]
        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        public string EmployeeAddress { get; set; }
        [Required]
        [DisplayName("Joining Date")]
        [DataType(DataType.Date)]
        public string EmployeeJoiningDate { get; set; }
        [Required]
        [DisplayName("Joining Time")]
        [DataType(DataType.Time)]
        public string EmployeeJoiningTime { get; set; }

    }
}