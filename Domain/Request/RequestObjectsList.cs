using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Request;

namespace Open.Domain.Request
{
    public class RequestObjectsList : List<RequestObject>
    {
        public RequestObjectsList(IEnumerable<RequestDbRecord> requestDbRecords)
        {
            foreach (var requestDbRecord in requestDbRecords)
            {
                Add( new RequestObject(requestDbRecord));
            }
        }
    }
}
