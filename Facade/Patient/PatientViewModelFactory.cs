using System;
using System.Collections.Generic;
using System.Text;
using Open.Domain.Patient;

namespace Open.Facade.Patient
{
    public class PatientViewModelFactory
    {
        public static PatientViewModel Create(PatientObject o)
        {
            return new PatientViewModel
            {
                PatientName = o.DbRecord.FirstName,
                ValidFrom = o.DbRecord.ValidFrom,
                ValidTo = o.DbRecord.ValidTo
            };
        }
    }
}
