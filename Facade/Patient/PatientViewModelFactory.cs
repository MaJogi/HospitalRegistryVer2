using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Facade.Patient
{
    public class PatientViewModelFactory
    {
        public static PatientViewModel Create(PatientObject o)
        {
            return new PatientViewModel
            {
                PatientId = o.DbRecord.Id,
                FirstName = o.DbRecord.FirstName,
                LastName = o.DbRecord.LastName,
                IdCode = o.DbRecord.IdCode,
                Problem = o.DbRecord.Problem,
                PhoneNumber = o.DbRecord.PhoneNumber,
                ProblemColor = setProblemColor(o), //was previously private set, but it didn't work with it
                ValidFrom = o.DbRecord.ValidFrom,
                ValidTo = o.DbRecord.ValidTo
                

            };
        }

        //Todo tõsta loogika dbrecord factorysse
        //internal static string setName(PatientObject o) //make it internal and fix not working with tests issue
        //{
        //   return o.DbRecord.FirstName + " " + o.DbRecord.LastName;
        //}

        //Todo tõsta dbrecordfactorisse
        internal static string setProblemColor(PatientObject o)
        {
            if (!ReferenceEquals(null, o)) // if patient isn't null
            {
               
                return o.DbRecord.Problem == "Head" ? "Yellow" : "Magenta"; 

            }
            else
            {
                return "Red";
            }
        }

        //Original way we did set methods in week4

        //internal static void setValidTo(PatientObject o)
        //{
        //    ValidTo = o.ValidTo;
        //}
    }
}
