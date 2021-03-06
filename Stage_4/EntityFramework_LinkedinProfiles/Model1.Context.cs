﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_LinkedinProfiles
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MonitoringEntities : DbContext
    {
        public MonitoringEntities()
            : base("name=MonitoringEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<GithubLanguage> GithubLanguages { get; set; }
        public virtual DbSet<GithubLinkedinCrossTable> GithubLinkedinCrossTables { get; set; }
        public virtual DbSet<GithubRepository> GithubRepositories { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<LinkedinEducation> LinkedinEducations { get; set; }
        public virtual DbSet<LinkedinExperience> LinkedinExperiences { get; set; }
        public virtual DbSet<LinkedinInterest> LinkedinInterests { get; set; }
        public virtual DbSet<LinkedinLanguage> LinkedinLanguages { get; set; }
        public virtual DbSet<LinkedinProfile> LinkedinProfiles { get; set; }
        public virtual DbSet<LinkedinSkill> LinkedinSkills { get; set; }
        public virtual DbSet<Proxy> Proxies { get; set; }
        public virtual DbSet<StaffSkill> StaffSkills { get; set; }
        public virtual DbSet<GithubProfile> GithubProfiles { get; set; }
    
        [DbFunction("MonitoringEntities", "fn_GetAllLinkedinProfileWithExperience")]
        public virtual IQueryable<fn_GetAllLinkedinProfileWithExperience_Result> fn_GetAllLinkedinProfileWithExperience()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_GetAllLinkedinProfileWithExperience_Result>("[MonitoringEntities].[fn_GetAllLinkedinProfileWithExperience]()");
        }
    
        [DbFunction("MonitoringEntities", "fn_GetLinkedinProfileAllInfoById")]
        public virtual IQueryable<fn_GetLinkedinProfileAllInfoById_Result> fn_GetLinkedinProfileAllInfoById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_GetLinkedinProfileAllInfoById_Result>("[MonitoringEntities].[fn_GetLinkedinProfileAllInfoById](@Id)", idParameter);
        }
    
        public virtual int sp_SetLastUpdateTimeInLinkedinProfileByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_SetLastUpdateTimeInLinkedinProfileByUsername", usernameParameter);
        }
    }
}
