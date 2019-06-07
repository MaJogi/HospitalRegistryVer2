using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Open.Aids;
using Open.Data.Doctor;

namespace Open.Infra.Doctor
{
    public class PatientsDoctorsInitializer
    {
        public static void Initialize(RegistryDbContext c)
        {
            c.Database.EnsureCreated();
            if (c.PatientsDoctors.Any()) return;
         

            foreach (var r in c.Doctors)
            {
                foreach (var p in c.Patients)
                {
                    var o = new DoctorPatientIDbRecord
                    {
                        Id = Guid.NewGuid().ToString(),
                        DoctorId = r.Id,
                        PatientId = p.Id,
                        ValidFrom = DateTime.Now,
                        ValidTo = DateTime.Now.AddYears(5)
                    };
                    c.PatientsDoctors.Add(o);
                    ;
                }
            }

            c.SaveChanges();
        }
    }
}
