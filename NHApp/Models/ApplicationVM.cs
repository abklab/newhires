using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NHApp.Models
{
    public class ApplicationVM
    {
        [Key]
        public string ApplicationID { get; set; }

        [Required(ErrorMessage = "Enter your First name"), DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your Last name"), DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Maiden Name")]
        public string MaidenName { get; set; }

        [Required(ErrorMessage = "Enter your Street Address"), DisplayName("Street Address")]
        public string Address_1 { get; set; }

        [DisplayName("Apt/Unit/Suite")]
        public string Address_2 { get; set; }

        [Required(ErrorMessage = "Enter your Home City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter your Home State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Enter your Zip-Code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Enter Time at this address"), DisplayName("Time at Address")]
        public string TimeAtAddr { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [DisplayName("Telephone")]
        public string PhoneNumber { get; set; }

        [Phone]
        [DisplayName("Cellphone")]
        public string CellPhone { get; set; }

        [Required(ErrorMessage = "Enter your Social Security Number")]
        public string SSN { get; set; }

        [Required(ErrorMessage = "Enter your Date of Birth"), DisplayName("Date of Birth")]
        [DataType(DataType.Text)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "This field is required."), DisplayName("Felony or Misdemeanor")]
        public string Felony { get; set; }

        [DisplayName("Explain Conviction")]
        public string FelonyExplanation { get; set; }

        [Required(ErrorMessage = "This field is required"), DisplayName("Do you have a Driving License")]
        public string HasDrivingLicense { get; set; }
        public string NoDL_Acknowledgement { get; set; }
        public string ArmedForces { get; set; }
        public string AFBranch { get; set; }
        public string NationalGuard { get; set; }
        public string NationalGuardSpecialty { get; set; }
        public string IsFirstEmployment { get; set; }
        public string IsPrevEmployee { get; set; }
        public string PrevEmployeeDetails { get; set; }
        public string HasSpecialLicense { get; set; }
        public string SpecialLicDetails { get; set; }
        public string ContactPrevEmployer { get; set; }

        [Required(ErrorMessage = "Did you complete this application yourself")]
        public string IsSelf_CompletedApp { get; set; }

        [Required(ErrorMessage = "Enter Name of your help"), DisplayName("Who Assisted You")]
        public string AppCompletedBy { get; set; }

        [ScaffoldColumn(false)]
        public int? App_status { get; set; }
        [ScaffoldColumn(false)]
        public DateTime AppDate { get; set; }
        [ScaffoldColumn(false)]
        public string Job { get; set; }
    }
}