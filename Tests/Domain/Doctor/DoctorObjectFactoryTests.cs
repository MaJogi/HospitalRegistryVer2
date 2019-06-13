using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Doctor;
using Open.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Domain.Doctor
{
    [TestClass]
    public class DoctorObjectFactoryTests
    {
        private string firstName;
        private string lastName;
        private string idCode;
        private string phoneNumber;
        private DateTime hireDate;
        private DoctorDbRecord r;
        private DoctorObject testDoctor;
        private DateTime max;

        [TestInitialize]
        public void initializeTestData()
        {
            max = DateTime.MaxValue;
            idCode = "39805325223";
            firstName = "Vladislav";
            lastName = "Jekimtsev";
            phoneNumber = "55555326";
        }

        [TestMethod]
        public void DoesFactoryMethodWorkTest()
        {
            testDoctor = DoctorObjectFactory.Create(firstName, lastName, idCode, phoneNumber, max);
            Assert.IsNotNull(testDoctor);
        }
    }
}
