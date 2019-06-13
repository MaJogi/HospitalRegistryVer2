using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Facade.Doctor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Facade.Doctor
{
    [TestClass]
    public class DoctorViewModelTests : ObjectTests<DoctorViewModel>
    {
        private DoctorViewModel patientView;

        protected override DoctorViewModel getRandomObject()
        {
            return GetRandom.Object<DoctorViewModel>();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new DoctorViewModel());
        }

        [TestMethod]
        public void DoctorIdTest()
        {

            string actual = getRandomObject().DoctorId = "1asfpl6lüypkagrt";
            Assert.AreEqual(actual, "1asfpl6lüypkagrt");
        }

        [TestMethod]
        public void FirstNameTest()
        {
            string actual = getRandomObject().FirstName = "Laura";
            Assert.AreEqual(actual, "Laura");
        }

        [TestMethod]
        public void LastNameTest()
        {
            string actual = getRandomObject().LastName = "Haura";
            Assert.AreEqual(actual, "Haura");
        }

        [TestMethod]
        public void IdCodeTest()
        {
            string expected = getRandomObject().IdCode = "39805345323";
            Assert.AreEqual(expected, "39805345323");
        }

        [TestMethod]
        public void PhoneNumberTest()
        {
            string expected = getRandomObject().PhoneNumber = "53443532";
            Assert.AreEqual(expected, "53443532");
        }

        [TestMethod]
        public void HireDateTest()
        {
            DateTime expected = getRandomObject().HireDate = DateTime.MaxValue;
            Assert.AreEqual(expected, DateTime.MaxValue);
        }
    }
}
