﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NewhireDBContext : DbContext
    {
        public NewhireDBContext()
            : base("name=NewhireDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ScreeningCompany> ScreeningCompanies { get; set; }
        public virtual DbSet<ApplicationWaiver> ApplicationWaivers { get; set; }
        public virtual DbSet<DrivingLicense> DrivingLicenses { get; set; }
        public virtual DbSet<EmploymentRecord> EmploymentRecords { get; set; }
        public virtual DbSet<PreEmpDrugTest> PreEmpDrugTests { get; set; }
        public virtual DbSet<PreviousEmployer> PreviousEmployers { get; set; }
        public virtual DbSet<EmploymentScreening> EmploymentScreenings { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
    
        public virtual ObjectResult<usp_Get_Job_List_Result> usp_Get_Job_List()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Get_Job_List_Result>("usp_Get_Job_List");
        }
    }
}