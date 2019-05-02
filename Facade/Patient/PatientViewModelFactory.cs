using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Facade.Patient
{
    public class PatientViewModelFactory
    {
        //public PatientViewModel(PatientObject patient)
        //{
        //    if (patient is null) return;
        //    setName(patient);
        //    setProblem(patient);
        //    setProblemColor(patient);
        //    setIdCode(patient);
        //    setValidFrom(patient);
        //    setValidTo(patient);
        //}
        public static PatientViewModel Create(PatientObject o)
        {
            
            return new PatientViewModel
            {
                PatientName = setName(o) /*o.DbRecord.FirstName + " " + o.DbRecord.LastName*/,
                IdCode = o.DbRecord.IdCode,
                Problem = o.DbRecord.Problem,
                ProblemColor = setProblemColor(o), //I had to comment out private set in PatientViewModel to make it work
                ValidFrom = o.DbRecord.ValidFrom,
                ValidTo = o.DbRecord.ValidTo

            };
        }

        internal static string setName(PatientObject o) //make it internal and fix not working with tests issue
        {
           return o.DbRecord.FirstName + " " + o.DbRecord.LastName;
        }

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
