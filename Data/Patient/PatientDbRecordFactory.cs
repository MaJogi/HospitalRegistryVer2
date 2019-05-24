using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Data.Patient
{
    //LOOGIKA ON ASENDATUD! SEE factory ei ole enam vajalik

    //public static class PatientDbRecordFactory
    //{
    //    public static PatientDbRecord Create() { return new PatientDbRecord(); } //is it right? Should it be null?

    //    public static PatientDbRecord Create(string firstName, string lastName, string idCode, string problem, string phoneNumber,
    //        DateTime? validFrom = null, DateTime? validTo = null)
    //    {
    //        var o = new PatientDbRecord()
    //        {
    //            FirstName = firstName ?? string.Empty,
    //            LastName = lastName ?? string.Empty,
    //            IdCode = idCode,
    //            Problem = problem,
    //            PhoneNumber = phoneNumber ?? string.Empty,
    //            ValidFrom = validFrom ?? DateTime.Now, //DateOfPatientCreation //Maybe DateTime.MinValue
    //            ValidTo = validTo ?? DateTime.MaxValue //Date when patient is excluded (deleted from system/registry)
                
    //        };
    //        return o;
    //    }


           

    //}
}
