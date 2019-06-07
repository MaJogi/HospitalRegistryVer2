using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Doctor;

namespace Open.Domain.Doctor
{
    public class PatientDoctorObjectsList : List<PatientDoctorObject>
    {
        public PatientDoctorObjectsList(IEnumerable<DoctorPatientIDbRecord> patientDbRecords)
        {
            foreach (var patientDbRecord in patientDbRecords) { Add(new PatientDoctorObject(patientDbRecord)); }
        }
    }
}
