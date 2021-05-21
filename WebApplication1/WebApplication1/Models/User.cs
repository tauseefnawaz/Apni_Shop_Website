using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DisplayName("Phone Number")]
        [RegularExpression("^.{11}", ErrorMessage = "Invalid Phone Number")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Address { get; set; }
        [RegularExpression("^.{8,}", ErrorMessage = "Password must be greather than 8 characters long")]
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
