using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Doctor;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Domain.Doctor
{
    public class PatientDoctorFactory
    {
        public static PatientDoctorObject Create(PatientObject patient, DoctorObject doctor,
            DateTime? validFrom = null, DateTime? validTo = null)
        {
            var o = new DoctorPatientIDbRecord
            {
                Patient = patient?.DbRecord ?? new PatientDbRecord(),
                Doctor = doctor?.DbRecord ?? new DoctorDbRecord(),
                ValidFrom = validFrom,
                ValidTo = validTo
            };
            o.DoctorId = o.Doctor.Id;
            o.PatientId = o.Patient.Id;
            return new PatientDoctorObject(o);
        }
    }
}
