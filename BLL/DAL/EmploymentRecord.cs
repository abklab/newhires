//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmploymentRecord
    {
        public int EntryID { get; set; }
        public string ApplicationID { get; set; }
        public string Division { get; set; }
        public string PaycheckDelivery { get; set; }
        public string CheckDeliveryLocation { get; set; }
        public string PaystubDeliveryLoc { get; set; }
        public string HireDate { get; set; }
        public string Provide_EEO { get; set; }
        public string EEO_Gender { get; set; }
        public string EEO_Ethnicity { get; set; }
        public string Benefits_Medical { get; set; }
        public string Benefits_Dental { get; set; }
        public string Benefits_Supplemental { get; set; }
        public string Benefits_Life { get; set; }
        public string Benefits_401K { get; set; }
        public string JobLocal { get; set; }
        public string HomeLocal { get; set; }
        public string CardNumber { get; set; }
        public string Trade { get; set; }
        public string Classification { get; set; }
        public string ApprenticeYear { get; set; }
        public string ApprenticeRate { get; set; }
        public string OtherClassification { get; set; }
        public string IsReferralAttached { get; set; }
    
        public virtual Application Application { get; set; }
    }
}
