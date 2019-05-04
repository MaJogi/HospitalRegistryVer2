using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Open.Data
{
    public class PatientT
    {
        // Registry has the power to create Patient from the data that they gather
        // from users via requests that they sent via online form

        //private const string requiredField = "Required field";
        //private const string lenghtIsToBig = "Length should be less than 20 characters";
        //private const string wrongLength = "Wrong Length";


        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        //[NameValidation]
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
