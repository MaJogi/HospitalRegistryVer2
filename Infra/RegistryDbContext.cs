using Microsoft.EntityFrameworkCore;
using Open.Data;
using Open.Data.Doctor;
using Open.Data.Patient;
using Open.Data.Request;
using Open.Infra.Common;

namespace Open.Infra
{
    public class RegistryDbContext : BaseDbContext<RegistryDbContext>
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options) { }

        public DbSet<PatientDbRecord> Patients { get; set; }
        public DbSet<DoctorDbRecord> Doctors { get; set; }

        public DbSet<RequestDbRecord> Requests { get; set; }

        public DbSet<DoctorPatientIDbRecord> PatientsDoctors { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PatientDbRecord>().ToTable("Patients");
            builder.Entity<DoctorDbRecord>().ToTable("Doctors");
            builder.Entity<RequestDbRecord>().ToTable("Requests");
            createNationalCurrencyTable(builder);
        }

        internal static void createNationalCurrencyTable(ModelBuilder b) 
        {
            const string table = "PatientsDoctors";
            createPrimaryKey<DoctorPatientIDbRecord>(b, table, a => new { a.Id, a.PatientId, a.DoctorId });
            createForeignKey<DoctorPatientIDbRecord, DoctorDbRecord>(b, table, x => x.DoctorId,
                x => x.Doctor);
            createForeignKey<DoctorPatientIDbRecord, PatientDbRecord>(b, table, x => x.PatientId,
                x => x.Patient);
        }
    }
}
