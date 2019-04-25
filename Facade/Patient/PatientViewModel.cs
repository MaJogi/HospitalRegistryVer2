using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Facade.Patient
{
    public class PatientViewModel
    {
        public PatientViewModel(PatientObject patient)
        {
            if (patient is null) return;
            setName(patient);
            setProblem(patient);
            setProblemColor(patient);
            setIdCode(patient);
            setValidFrom(patient);
            setValidTo(patient);

        }

        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string IdCode { get; set; }
        public string Problem { get; set; }
        public string ProblemColor { get; private set; } = "red";
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        internal void setName(PatientDbRecord p) //make it internal and fix not working with tests issue
        {
            PatientName = p.FirstName + " " + p.LastName;
        }

        internal void setProblemColor(PatientDbRecord p)
        {
            if (!ReferenceEquals(null, p)) // if patient isn't null
            {
                ProblemColor = p.Problem == "Head" ? "Yellow" : "Magenta";

            }
            else
            {
                ProblemColor = "Red";
            }
        }

        internal void setProblem(PatientDbRecord p)
        {
            Problem = p.Problem;
        }

        internal void setIdCode(PatientDbRecord p)
        {
            IdCode = p.IdCode;
        }

        internal void setValidFrom(PatientDbRecord p)
        {
            ValidFrom = p.ValidFrom;
        }
        internal void setValidTo(PatientDbRecord p)
        {
            ValidTo = p.ValidTo;
        }
    }
}
