using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Request;
using Open.Domain.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Domain.Request
{
    [TestClass]
    public class RequestObjectFactoryTests
    {
        private string firstName;
        private string lastName;
        private string idCode;
        private string message;
        private string phoneNumber;
        private DateTime dateSent;
        private RequestDbRecord r;
        private RequestObject testRequest;
        private DateTime max;

        [TestInitialize]
        public void initializeTestData()
        {
            max = DateTime.MaxValue;
            idCode = "39805225223";
            firstName = "Vlad";
            lastName = "Jek";
            message = "Head";
            phoneNumber = "55555556";
        }

        [TestMethod]
        public void DoesFactoryMethodWorkTest()
        {
            testRequest = RequestObjectFactory.Create(firstName, lastName, idCode, message, phoneNumber, max);
            Assert.IsNotNull(testRequest);

        }
    }
}


