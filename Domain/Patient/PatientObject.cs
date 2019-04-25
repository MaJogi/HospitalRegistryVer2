using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;

namespace Open.Domain.Patient
{
    public class PatientObject
    {
        public readonly PatientDbRecord DbRecord;

        public PatientObject(PatientDbRecord r) { DbRecord = r;}
    }
}
