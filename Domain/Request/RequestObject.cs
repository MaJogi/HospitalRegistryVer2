using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Request;

namespace Open.Domain.Request
{
    public class RequestObject
    {
        public readonly RequestDbRecord DbRecord;

        public RequestObject(RequestDbRecord r)
        {
            DbRecord = r;
        }
    }
}
