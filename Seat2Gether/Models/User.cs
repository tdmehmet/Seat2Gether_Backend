using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{
    [Table("Tb_Users")]
    public class User : IdentityUser
    {
        [Display(Name = "PersonnelName")]
        public string PersonnelName { get; set; }

        [Display(Name = "PersonnelSurname")]
        public string PersonnelSurname { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public DateTime DateCreated { get; set; }
        public Boolean Activated { get; set; }
    }
}