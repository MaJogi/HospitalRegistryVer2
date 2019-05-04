using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Facade.Patient
{
    public class PatientViewModel
    {
        [DisplayName("ID")]
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCode { get; set; }
        public string Problem { get; set; }
        public string ProblemColor { get; /*private*/ set; } = "red";
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }


       
        
        
       


    }

}
