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
    
    public partial class Application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Application()
        {
            this.ApplicationWaivers = new HashSet<ApplicationWaiver>();
            this.DrivingLicenses = new HashSet<DrivingLicense>();
            this.EmploymentRecords = new HashSet<EmploymentRecord>();
            this.EmploymentScreenings = new HashSet<EmploymentScreening>();
            this.PreEmpDrugTests = new HashSet<PreEmpDrugTest>();
            this.PreviousEmployers = new HashSet<PreviousEmployer>();
        }
    
        public int EntryID { get; set; }
        public string ApplicationID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string TimeAtAddr { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhone { get; set; }
        public string SSN { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Felony { get; set; }
        public string FelonyExplanation { get; set; }
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
        public string IsSelf_CompletedApp { get; set; }
        public string AppCompletedBy { get; set; }
        public Nullable<int> App_status { get; set; }
        public System.DateTime AppDate { get; set; }
        public string Job { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationWaiver> ApplicationWaivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrivingLicense> DrivingLicenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentRecord> EmploymentRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploymentScreening> EmploymentScreenings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreEmpDrugTest> PreEmpDrugTests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreviousEmployer> PreviousEmployers { get; set; }
    }
}