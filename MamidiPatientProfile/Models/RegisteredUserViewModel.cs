using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiPatientProfile.Models
{
    public class RegisteredUserViewModel
    {
        public int RegisteredUserId { get; set; }

        [Required(ErrorMessage = "Your email address is required.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Your password is required.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string Salt { get; set; }
    }
}