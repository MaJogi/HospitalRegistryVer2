using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Patient;

namespace Open.Tests.Domain.Patient
{
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

        private void initializeTestData()
        {
            var min = DateTime.MinValue;
            var max = DateTime.MaxValue;
            idCode = "39805225211";
            firstName = "Egor";
            lastName = "Baptev";
            problem = "etozeptev";
            phoneNumber = "55555555";

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
