using Microsoft.EntityFrameworkCore;
using Open.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Open.Infra.Doctor
{
    public class DoctorObjectsRepository : IDoctorObjectsRepository
    {
        private readonly RegistryDbContext db;

        public DoctorObjectsRepository(RegistryDbContext context)
        {
            db = context;
        }

        public async Task<DoctorObject> GetObject(string id)
        {

            var o = await db.Doctors.FindAsync(id);
            return new DoctorObject(o);
        }

        public async Task<IEnumerable<DoctorObject>> GetObjectsList()
        {
            var l = await db.Doctors.ToListAsync();
            return new DoctorObjectsList(l);
        }

        public async Task<DoctorObject> AddObject(DoctorObject o)
        {
            db.Doctors.Add(o.DbRecord);
            await db.SaveChangesAsync();
            return o;
        }

        public async Task UpdateObject(DoctorObject o)
        {
            db.Doctors.Update(o.DbRecord);
            await db.SaveChangesAsync();
        }

        public async Task DeleteObject(DoctorObject o)
        {
            db.Doctors.Remove(o.DbRecord);
            await db.SaveChangesAsync();
        }
    }
}
