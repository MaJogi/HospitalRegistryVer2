using Microsoft.EntityFrameworkCore;
using Open.Data;

namespace Open.Infra
{
    public class RegistryDbContext : DbContext
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<Patient>().ToTable("Patients");
        //}

        //public DbSet<Patient> Patients { get; set; }
    }
}
