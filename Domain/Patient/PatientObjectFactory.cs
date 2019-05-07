using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;

namespace Open.Domain.Patient
{
    public static class PatientObjectFactory
    {
        public static PatientObject Create(string firstName, string lastName, string idCode, string problem, string phoneNumber,
            DateTime? validFrom = null, DateTime? validTo = null)
        {
            var o = PatientDbRecordFactory.Create(firstName, lastName, idCode, problem, phoneNumber, validFrom, validTo );
            return new PatientObject(o);
        }
    }
}
