using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Doctor;

namespace Open.Domain.Doctor
{
    public class DoctorObjectsList : List<DoctorObject>
    {
        public DoctorObjectsList(IEnumerable<DoctorDbRecord> patientDbRecords)
        {
            foreach (var patientDbRecord in patientDbRecords) { Add(new DoctorObject(patientDbRecord)); }
        }
    }
}
