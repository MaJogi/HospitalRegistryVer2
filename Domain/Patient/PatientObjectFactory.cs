using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;

namespace Open.Domain.Patient
{
    public static class PatientObjectFactory
    {
        public static PatientObject Create(string firstName, string lastName, 
            string idCode, string problem, string phoneNumber,
            DateTime? validFrom = null, DateTime? validTo = null)
        {
            var o = new PatientDbRecord()
            {
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                IdCode = idCode,
                PhoneNumber = phoneNumber ?? string.Empty,
                ValidFrom = validFrom ?? DateTime.Now, //DateOfPatientCreation //Maybe DateTime.MinValue

            };

            return new PatientObject(o);
        }
    }
}
