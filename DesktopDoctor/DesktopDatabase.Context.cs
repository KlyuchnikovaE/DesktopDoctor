﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopDoctor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DesktopDoctorDatabaseEntities : DbContext
    {
        public DesktopDoctorDatabaseEntities()
            : base("name=DesktopDoctorDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<ReceprionProcedure> ReceprionsProcedures { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<ReceptionComplaint> ReceptionsComplaints { get; set; }
        public DbSet<ReceptionMedicine> ReceptionsMedicines { get; set; }
        public DbSet<ReceptionRecommendation> ReceptionsRecommendations { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<SecurityLevel> SecurityLevels { get; set; }
    }
}