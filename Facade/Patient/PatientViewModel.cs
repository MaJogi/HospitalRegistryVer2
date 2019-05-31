using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Open.Core;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Facade.Patient
{
    public class PatientViewModel
    {
        [DisplayName("ID")]
        public string PatientId { get; set; }
        [NameValidation]
        public string FirstName { get; set; }
        [NameValidation]
        public string LastName { get; set; }
        [IdCodeValidation]
        public string IdCode { get; set; }
        [ProblemValidation]
        public string Problem { get; set; }
        [NumberPhoneValidation]
        public string PhoneNumber { get; set; }
        public string ProblemColor { get; /*private*/ set; } = "red";
        public DateTime ValidFrom { get; set; } //Maybe do formattedValidFrom right here in get?

        public string FormattedValidFrom { get { return this.ValidFrom.ToString("d"); } }

        public DateTime ValidTo { get; set; }
        public string FormattedValidTo { get { return this.ValidTo.ToString("d"); } }




    }

}
