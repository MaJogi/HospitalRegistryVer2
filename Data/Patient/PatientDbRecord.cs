using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Open.Data.Patient
{
    public class PatientDbRecord
    {
        // Registry has the power to create Patient from the data that they gather
        // from users via requests that they sent via online form

        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PatientId { get; set; }
        
        //[NameValidation] Add validation as soon as validation class i done!
        public string FirstName { get; set; }
        //[NameValidation]
        public string LastName { get; set; }
        //[IdCodeValidation]
        public string IdCode { get; set; }
        public string Problem { get; set; } // will look like a comment on the site
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        //Todo
        //Add phonenumber
        //Add complex logic to validate idcode and get birthdate and gender from idcode.
    }
}
