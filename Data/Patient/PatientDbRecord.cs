using Open.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Open.Data.Patient
{
    public class PatientDbRecord
    {

        [ScaffoldColumn(false)]
        [Key]
        public string Id { get; set; }
        [NameValidation]
        public string FirstName { get; set; }
        [NameValidation]
        public string LastName { get; set; }
        [IdCodeValidation]
        public string IdCode { get; set; }
        [ProblemValidation]
        public string Problem { get; set; } // will look like a comment on the site
        [NumberPhoneValidation]
        public string PhoneNumber { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

       
        
        
        //Todo
        //Add complex logic to validate idcode and get birthdate and gender from idcode.
    }
}
