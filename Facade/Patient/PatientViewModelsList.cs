using System;
using System.Collections.Generic;
using System.Text;
using Open.Domain.Patient;

namespace Open.Facade.Patient
{
    public class PatientViewModelsList : List<PatientViewModel>
    {
        public PatientViewModelsList(IEnumerable<PatientObject> l)
        {
            foreach (var e in l)
            {
                Add(PatientViewModelFactory.Create(e));
            }
        }
    }
 
}
