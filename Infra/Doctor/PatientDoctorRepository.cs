using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Open.Data.Doctor;
using Open.Domain.Doctor;
using Open.Domain.Patient;

namespace Open.Infra.Doctor
{
    public class PatientDoctorRepository : IDoctorPatientObjectsRepository
    {
        private readonly DbSet<DoctorPatientIDbRecord> dbSet;
        private readonly RegistryDbContext db;

        public PatientDoctorRepository(RegistryDbContext context)
        {
            db = context;
            dbSet = context.PatientsDoctors;
        }

        public async Task<PatientDoctorObject> GetObject(string id)
        {
            var o = await db.PatientsDoctors.FindAsync(id);
            return new PatientDoctorObject(o);
        }

        public async Task<IEnumerable<PatientDoctorObject>> GetObjectsList()
        {
            var l = await db.PatientsDoctors.ToListAsync();
            return new PatientDoctorObjectsList(l);
        }

        public async Task<PatientDoctorObject> AddObject(PatientDoctorObject o)
        {
            db.PatientsDoctors.Add(o.DbRecord);
            await db.SaveChangesAsync();
            return o;
        }

        public async Task UpdateObject(PatientDoctorObject o)
        {
            db.PatientsDoctors.Update(o.DbRecord);
            await db.SaveChangesAsync();
        }

        public async Task DeleteObject(PatientDoctorObject o)
        {
            db.PatientsDoctors.Remove(o.DbRecord);
            await db.SaveChangesAsync();
        }
        public async Task LoadDoctors(PatientObject patient)
        {
            if (patient is null) return;
            var id = patient.DbRecord?.Id ?? string.Empty;
            var countries = await dbSet.Include(x => x.Doctor).Where(x => x.PatientId == id)
                .AsNoTracking().ToListAsync();
            //foreach (var c in countries)
            //    patient.UsedInCountry(new Country(c.Country));
        }

        public async Task LoadPatients(DoctorObject doctor)
        {
            if (doctor is null) return;
            var id = doctor.DbRecord?.Id ?? string.Empty;
            var countries = await dbSet.Include(x => x.Patient).Where(x => x.DoctorId == id)
                .AsNoTracking().ToListAsync();
        }
    }
}
