using Microsoft.EntityFrameworkCore;
using Open.Data;
using Open.Data.Patient;

namespace Open.Infra
{
    public class RegistryDbContext : DbContext
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options) { }

        public DbSet<PatientDbRecord> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PatientDbRecord>().ToTable("Patients");
        }


    }
}
