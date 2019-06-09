using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Data.Request
{
    [TestClass]
    public class RequestDbRecordTests : ObjectTests<RequestDbRecord>
    {
        private RequestDbRecord request;

        [TestInitialize]
        public void Initialize()
        {
            request = new RequestDbRecord();
        }

        protected override RequestDbRecord getRandomObject()
        {
            return GetRandom.Object<RequestDbRecord>();
        }

        [TestMethod]
        public override void CanCreateTest()
        {
            Assert.IsNotNull(obj); 
        }

        [TestMethod]
        public void IdTest()
        {
            string actual = request.Id = "3asfpl5lüüpkadaf";
            Assert.AreEqual(actual, "3asfpl5lüüpkadaf");
        }

        [TestMethod]
        public void FirstNameTest()
        {
            string actual = request.FirstName = "Mark";
            Assert.AreEqual(actual, "Mark");
        }

        [TestMethod]
        public void LastNameTest()
        {
            string actual = request.LastName = "Marek";
            Assert.AreEqual(actual, "Marek");
        }

        [TestMethod]
        public void IdCodeTest()
        {
            string expected = request.IdCode = "39805225223";
            Assert.AreEqual(expected, "39805225223");
        }
        [TestMethod]
        public void ProblemTest()
        {
            string expected = request.Message = "Head";
            Assert.AreEqual(expected, "Head");
        }
        [TestMethod]
        public void PhoneNumberTest()
        {
            string expected = request.PhoneNumber = "55543567";
            Assert.AreEqual(expected, "55543567");
        }

        [TestMethod]
        public void DataSentTest()
        {
            DateTime expected = request.DateSent = DateTime.Today;
            Assert.AreEqual(expected, DateTime.Today);
        }
    }
}
