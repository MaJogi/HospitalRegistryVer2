using Open.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Facade.Doctor
{
    class DoctorViewModelFactory
    {
        public static DoctorViewModel Create(DoctorObject o)
        {
            return new DoctorViewModel
            {
                DoctorId = o.DbRecord.Id,
                FirstName = o.DbRecord.FirstName,
                LastName = o.DbRecord.LastName,
                IdCode = o.DbRecord.IdCode,
                PhoneNumber = o.DbRecord.PhoneNumber,
                ValidFrom = o.DbRecord.HireDate,
                Departments = o.DbRecord.Departments
            };
        }
    }
}
