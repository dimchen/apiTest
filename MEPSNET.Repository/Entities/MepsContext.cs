using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MEPSNET.Repositories.Entities
{

    public partial class MepsContext : DbContext
    {
        //public MepsContext : base("name = DefaultConnection")
        //{
        //    Debug.Write(Database.Connection.ConnectionString);
        //}
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Hardware> Hardwares { get; set; }
        public virtual DbSet<Problem> Problems { get; set; }
        public virtual DbSet<HosptialGroup> HospitalGroups { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<InternalUser> InternalUsers { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Hospital>().Property(e => e.OrganizationName);
        //}
    }
}