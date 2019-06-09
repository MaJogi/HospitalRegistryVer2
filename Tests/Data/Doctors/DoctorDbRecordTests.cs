using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Doctor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Data.Doctors
{
    [TestClass]
    public class DoctorDbRecordTests : ObjectTests<DoctorDbRecord>
    {
        private DoctorDbRecord doctor;

        [TestInitialize]
        public void Initialize()
        {
            doctor = new DoctorDbRecord();
        }

        protected override DoctorDbRecord getRandomObject()
        {
            return GetRandom.Object<DoctorDbRecord>();
        }

        [TestMethod]
        public override void CanCreateTest()
        {
            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public void IdTest()
        {
            string actual = doctor.Id = "3asfpl5lüüpkadaf";
            Assert.AreEqual(actual, "3asfpl5lüüpkadaf");
        }

        [TestMethod]
        public void FirstNameTest()
        {
            string actual = doctor.FirstName = "Antuan";
            Assert.AreEqual(actual, "Antuan");
        }

        [TestMethod]
        public void LastNameTest()
        {
            string actual = doctor.LastName = "Henrok";
            Assert.AreEqual(actual, "Henrok");
        }

        [TestMethod]
        public void IdCodeTest()
        {
            string expected = doctor.IdCode = "39805345223";
            Assert.AreEqual(expected, "39805345223");
        }
        
        [TestMethod]
        public void PhoneNumberTest()
        {
            string expected = doctor.PhoneNumber = "53443556";
            Assert.AreEqual(expected, "53443556");
        }

        [TestMethod]
        public void HireDateTest()
        {
            DateTime expected = doctor.HireDate = DateTime.Today;
            Assert.AreEqual(expected, DateTime.Today);
        }
    }
}
