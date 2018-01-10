using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiPatientProfile.Models
{
    public class NewUserViewModel
    {
        [Required(ErrorMessage = "Your first name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Your email address is required.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Your password must contain at least 8 characters that consist of an upper-case letter, a lower-case letter, a number, and a symbol.")]
        [Display(Name = "Password")]
        [RegularExpression(@"(?=^.{8,}$)(?=.*\d)(?=.*[!@#$%^&*]+)(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Your password does not meet the requirements.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must confirm your password.")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Your passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}