using Microsoft.EntityFrameworkCore;
using Open.Data;
using Open.Data.Doctor;
using Open.Data.Patient;
using Open.Data.Request;

namespace Open.Infra
{
    public class RegistryDbContext : DbContext
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options) { }

        public DbSet<PatientDbRecord> Patients { get; set; }
        public DbSet<DoctorDbRecord> Doctors { get; set; }

        public DbSet<RequestDbRecord> Requests { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PatientDbRecord>().ToTable("Patients");
            builder.Entity<DoctorDbRecord>().ToTable("Doctors");
            builder.Entity<RequestDbRecord>().ToTable("Requests");
        }


    }
}
