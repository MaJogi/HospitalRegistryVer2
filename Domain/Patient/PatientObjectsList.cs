using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;

namespace Open.Domain.Patient
{
    public class PatientObjectsList : List<PatientObject>
    {
        public PatientObjectsList(IEnumerable<PatientDbRecord> patientDbRecords)
        {
            foreach (var patientDbRecord in patientDbRecords) { Add(new PatientObject(patientDbRecord));}                                                      
        }
    }
}
