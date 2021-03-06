﻿using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Doctor;


namespace Open.Domain.Doctor
{
    public class DoctorObjectFactory
    {
        public static DoctorObject Create(string firstName, string lastName,
            string idCode, string phoneNumber,
            DateTime hireDate)
        {
            var o = new DoctorDbRecord()
            {
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                IdCode = idCode,
                PhoneNumber = phoneNumber ?? string.Empty,
                HireDate = hireDate,
                
            };

            return new DoctorObject(o);
        }
    }
}
