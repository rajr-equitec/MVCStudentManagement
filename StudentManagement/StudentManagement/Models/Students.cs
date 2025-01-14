using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class Students

    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Roll no. is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Roll no. must be a positive number.")]
        public int Rollno { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        [StringLength(100, ErrorMessage = "Department name cannot exceed 100 characters.")]
        public string Depart { get; set; }

        public string deptname { get; set; }

        [Required(ErrorMessage = "DOB is required.")]
       
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
       
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100, ErrorMessage = "Address cannot exceed 100 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
    
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
        public long phone { get; set; }

        public int depid { get; set; }


       
    }
}