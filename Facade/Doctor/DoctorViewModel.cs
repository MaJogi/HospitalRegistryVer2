using System;
using System.Collections.Generic;
using System.Text;
using Open.Core;
using System.ComponentModel;

namespace Open.Facade.Doctor
{
    class DoctorViewModel
    {
        [DisplayName("ID")]
        public string DoctorId { get; set; }
        [NameValidation]
        public string FirstName { get; set; }
        [NameValidation]
        public string LastName { get; set; }
        [IdCodeValidation]
        public string IdCode { get; set; }
        [ProblemValidation]
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; } //Maybe do formattedValidFrom right here in get?




    }
}
