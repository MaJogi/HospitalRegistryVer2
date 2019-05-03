using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Open.Domain.Patient;

namespace Open.Infra.Patient
{
    public class PatientObjectsRepository : IPatientObjectsRepository
    {
        private readonly RegistryDbContext db;

        public PatientObjectsRepository(RegistryDbContext context)
        {
            db = context; 
        }

        public async Task<PatientObject> GetObject(int id)
        {
            var o = await db.Patients.FindAsync(id);
            return new PatientObject(o);
        }

        public async Task<IEnumerable<PatientObject>> GetObjectsList()
        {
            var l = await db.Patients.ToListAsync();
            return new PatientObjectsList(l);
        }

        public async Task<PatientObject> AddObject(PatientObject o)
        {
            db.Patients.Add(o.DbRecord);
            await db.SaveChangesAsync();
            return o;
        }

        public async void UpdateObject(PatientObject o)
        {
            db.Patients.Update(o.DbRecord);
            await db.SaveChangesAsync();
        }

        public async void DeleteObject (PatientObject o)
        {
            db.Patients.Remove(o.DbRecord);
            await db.SaveChangesAsync();
        }
    }
}
