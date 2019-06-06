﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Open.Core;

namespace Open.Data.Doctor
{
    public class DoctorDbRecord
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
        [NumberPhoneValidation]
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        //public List<Department> Departments { get; set; }
        public List<string> Departments { get; set; }
    }
}