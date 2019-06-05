using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Open.Data.Request
{
    public class RequestDbRecord
    {
        [ScaffoldColumn(false)]
        [Key]
        public string Id { get; set; } //Now creates unique hash

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCode { get; set; }
        public string Message { get; set; } 
        public string PhoneNumber { get; set; }
        public DateTime DateSent { get; set; }
        
        //Todo
    }
}
