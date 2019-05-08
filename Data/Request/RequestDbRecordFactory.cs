using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Data.Request
{
    public static class RequestDbRecordFactory
    {
        public static RequestDbRecord Create() { return new RequestDbRecord(); } //is it right? Should it be null?

        public static RequestDbRecord Create(string firstName, string lastName, string idCode, string message, string phoneNumber)
        {
            var o = new RequestDbRecord()
            {
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                IdCode = idCode,
                Message = message,
                PhoneNumber = phoneNumber ?? string.Empty,
       

            };
            return o;
        }
    }
}
