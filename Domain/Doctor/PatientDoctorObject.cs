using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Doctor;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Domain.Doctor
{
    public class PatientDoctorObject
    {
        public readonly DoctorPatientIDbRecord DbRecord;
        public readonly PatientObject Patient;
        public readonly DoctorObject Doctor;
        public PatientDoctorObject(DoctorPatientIDbRecord dbRecord) 
        {
            dbRecord.Doctor = dbRecord.Doctor ?? new DoctorDbRecord();
            dbRecord.Patient = dbRecord.Patient ?? new PatientDbRecord();

            Patient = new PatientObject(dbRecord.Patient);
            Doctor = new DoctorObject(dbRecord.Doctor);
            DbRecord = dbRecord;
        }

    }
}
