using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NHApp.Models
{
    public class PreviousEmployer
    {
        [Key]
        public int EntryID { get; set; }
        [ScaffoldColumn(false)]
        public string ApplicationID { get; set; }

        [DisplayName("Name of Employer")]
        [Required(ErrorMessage ="Enter name of Employer")]
        public string EmployerName { get; set; }

        [DisplayName("Business Address")]
        [Required(ErrorMessage = "Enter Address of Employer")]
        public string BusinessAddress { get; set; }

       
        [Required(ErrorMessage = "Enter Employer City")]
        public string City { get; set; }

      
        [Required(ErrorMessage = "Select Employer State)")]
        public string State { get; set; }
        public string Zip { get; set; }

        [DisplayName("Employer Phone Number")]
        [Required(ErrorMessage = "Provide phone contact of employer.")]
        public string Phone { get; set; }
        public string Supervisor { get; set; }

        [DisplayName("Job Title")]
        [Required(ErrorMessage = "Provide your Job Title")]
        public string JobTitle { get; set; }

        [DisplayName("From Date")]
        [Required(ErrorMessage = "Provide Start Date (MM/YYYY)")]
        public string FromDate { get; set; }

        [DisplayName("To Date")]
        [Required(ErrorMessage = "Provide End Date (MM/YYYY)")]
        public string ToDate { get; set; }

        [DisplayName("Reason for Leaving")]
        [Required(ErrorMessage = "Provide reason for leaving.")]
        public string ReasonForLeaving { get; set; }

        [DisplayName("Duties and Responsibilties")]
        [Required(ErrorMessage = "Provide details of your duties/responsibilities")]
        public string JobDuties { get; set; }

    }
}