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
                Problem = problem,
                PhoneNumber = phoneNumber ?? string.Empty,
                ValidFrom = validFrom ?? DateTime.Now, //DateOfPatientCreation //Maybe DateTime.MinValue
                ValidTo = validTo ?? DateTime.MaxValue //Date when patient is excluded (deleted from system/registry)

            };

            return new PatientObject(o);
        }
    }
}
