using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Doctor;

namespace Open.Domain.Doctor
{
    public class DoctorObject
    {
        public readonly DoctorDbRecord DbRecord;

        public DoctorObject(DoctorDbRecord r) { DbRecord = r; }
    }
}
