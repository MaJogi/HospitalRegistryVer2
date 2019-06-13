using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Request;
using Open.Domain.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Domain.Request
{
    [TestClass]
    public class RequestObjectTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new RequestObject(new RequestDbRecord()));
        }
    }
}
