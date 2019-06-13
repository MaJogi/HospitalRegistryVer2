using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Patient;
using Open.Domain.Patient;

namespace Open.Tests.Domain.Patient
{
    
    [TestClass]
    public class PatientObjectFactoryTests
    {
        private string firstName;
        private string lastName;
        private string idCode;
        private string problem;
        private string phoneNumber;
        private DateTime validFrom;
        private DateTime validTo;
        private PatientDbRecord r;
        private PatientObject testPatient;
        private DateTime min;
        private DateTime max;
        

        [TestInitialize]
        public void initializeTestData()
        {
            min = DateTime.MinValue;
            max = DateTime.MaxValue;
            idCode = "39805225211";
            firstName = "Egor";
            lastName = "Baptev";
            problem = "etozelaptev";
            phoneNumber = "55555555";
            // testPatient = PatientObjectFactory.Create(firstName, lastName, idCode, problem, phoneNumber, min, max);
        }

        [TestMethod]
        public void DoesFactoryMethodWorkTest()
        {
           
            testPatient = PatientObjectFactory.Create(firstName, lastName, idCode, problem, phoneNumber, min, max);
            Assert.IsNotNull(testPatient);
            
        }
        private void validateResults(string firstName = "", string lastName = "",
            string IdCode = "", string problem = "", string phoneNumber = "",
            DateTime? validFrom = null, DateTime? validTo = null)
        {
            Assert.AreEqual(firstName, r.FirstName);
            Assert.AreEqual(lastName, r.FirstName);
            Assert.AreEqual(IdCode, r.FirstName);
            Assert.AreEqual(problem, r.FirstName);
            Assert.AreEqual(phoneNumber, r.FirstName);
            //add validfrom thing
            //add validTo thing
        }
    }
}
