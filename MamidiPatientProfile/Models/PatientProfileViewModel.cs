using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamidiPatientProfile.Models
{
    public class PatientProfileViewModel
    {
        [Required(ErrorMessage = "You must enter the patient's first name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "You must enter the patient's last name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must select the patient's gender.")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "You must enter the patient's address.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "You must enter the patient's phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "You must enter the patient's allergies.")]
        [Display(Name = "Allergies")]
        public string Allergies { get; set; }

        [Required(ErrorMessage = "You must enter the patient's past medical history.")]
        [Display(Name = "Past Medical History")]
        public string PastMedicalHistory { get; set; }

        [Required(ErrorMessage = "You must enter the patient's family history.")]
        [Display(Name = "Family History")]
        public string FamilyHistory { get; set; }

        [Required(ErrorMessage = "You must enter the patient's social history.")]
        [Display(Name = "Social History")]
        public string SocialHistory { get; set; }

        [Required(ErrorMessage = "You must enter the patient's history of present/current illness.")]
        [Display(Name = "History of Present Illness")]
        public string HistoryPresentIllness { get; set; }

        [Display(Name = "Medication History")]
        public string MedicationHistory { get; set; }
    }
}