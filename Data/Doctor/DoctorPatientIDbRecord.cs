using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Open.Data.Patient;

namespace Open.Data.Doctor
{
    public class DoctorPatientIDbRecord
    {
        [Key]
        public string Id { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public virtual DoctorDbRecord Doctor { get; set; }
        public virtual PatientDbRecord Patient { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
