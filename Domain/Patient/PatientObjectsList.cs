using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;

namespace Open.Domain.Patient
{
    public class PatientObjectsList : List<PatientObject>
    {
        public PatientObjectsList(IEnumerable<PatientDbRecord> l)
        {
            foreach (var e in l) { Add(new PatientObject(e));}                                                      
        }
    }
}
