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
    
    public partial class PreviousEmployer
    {
        public int EntryID { get; set; }
        public string ApplicationID { get; set; }
        public string EmployerName { get; set; }
        public string BusinessAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Supervisor { get; set; }
        public string JobTitle { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string ReasonForLeaving { get; set; }
        public string JobDuties { get; set; }
    
        public virtual Application Application { get; set; }
    }
}
