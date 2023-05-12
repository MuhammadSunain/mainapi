﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecmapi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ecomSchoolEntities : DbContext
    {
        public ecomSchoolEntities()
            : base("name=ecomSchoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<academicRegister> academicRegisters { get; set; }
        public virtual DbSet<Caste> Castes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<entity_Type> entity_Type { get; set; }
        public virtual DbSet<fr_CaseGroup> fr_CaseGroup { get; set; }
        public virtual DbSet<fr_CASERULES> fr_CASERULES { get; set; }
        public virtual DbSet<fr_casestage> fr_casestage { get; set; }
        public virtual DbSet<fr_CaseType> fr_CaseType { get; set; }
        public virtual DbSet<fr_certificateType> fr_certificateType { get; set; }
        public virtual DbSet<fr_Desk_caseRegister> fr_Desk_caseRegister { get; set; }
        public virtual DbSet<fr_Purpose> fr_Purpose { get; set; }
        public virtual DbSet<fr_Source> fr_Source { get; set; }
        public virtual DbSet<hdr_Ac_Book> hdr_Ac_Book { get; set; }
        public virtual DbSet<hdr_Ac_bookAuthor> hdr_Ac_bookAuthor { get; set; }
        public virtual DbSet<hdr_Ac_bookCategory> hdr_Ac_bookCategory { get; set; }
        public virtual DbSet<hdr_Ac_bookPublisher> hdr_Ac_bookPublisher { get; set; }
        public virtual DbSet<hdr_Ac_bookType> hdr_Ac_bookType { get; set; }
        public virtual DbSet<hdr_Ac_Course> hdr_Ac_Course { get; set; }
        public virtual DbSet<hdr_Ac_Section> hdr_Ac_Section { get; set; }
        public virtual DbSet<hdr_Ac_Section_group> hdr_Ac_Section_group { get; set; }
        public virtual DbSet<hdr_AC_Subject> hdr_AC_Subject { get; set; }
        public virtual DbSet<hdr_Ac_subjectType> hdr_Ac_subjectType { get; set; }
        public virtual DbSet<hdr_Ac_Syllabus> hdr_Ac_Syllabus { get; set; }
        public virtual DbSet<hdr_HR_EmployeeProfile> hdr_HR_EmployeeProfile { get; set; }
        public virtual DbSet<hdr_Sm_studentinfo> hdr_Sm_studentinfo { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sms_Qualification> Sms_Qualification { get; set; }
        public virtual DbSet<SMS_QualificationType> SMS_QualificationType { get; set; }
        public virtual DbSet<sms_Religion> sms_Religion { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<student_category> student_category { get; set; }
        public virtual DbSet<ut_clients> ut_clients { get; set; }
        public virtual DbSet<hdr_FOAdmEnquiry> hdr_FOAdmEnquiry { get; set; }
        public virtual DbSet<hdr_SMAcademicYear> hdr_SMAcademicYear { get; set; }
        public virtual DbSet<userEntity> userEntities { get; set; }
        public virtual DbSet<mst_user_Entity> mst_user_Entity { get; set; }
        public virtual DbSet<ut_user_auth> ut_user_auth { get; set; }
        public virtual DbSet<mst_region> mst_region { get; set; }
        public virtual DbSet<hdr_occupation> hdr_occupation { get; set; }
    }
}
