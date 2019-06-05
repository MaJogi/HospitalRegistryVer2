using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Request;

namespace Open.Domain.Request
{
    public static class RequestObjectFactory
    {
        public static RequestObject Create(string firstName, string lastName, string idCode,
            string message, string phoneNumber, DateTime? dateSent = null)
        {
            var o = new RequestDbRecord()
            {
                FirstName = firstName,
                LastName = lastName,
                IdCode = idCode,
                Message = message,
                PhoneNumber = phoneNumber,
                DateSent = dateSent ?? DateTime.Now
            };
            return new RequestObject(o);
        }
    }
}
