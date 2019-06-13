using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Facade.Patient;

namespace Open.Tests.Facade.Patient
{
    [TestClass]
    public class PatientViewModelTests : ObjectTests<PatientViewModel>
    {
        private PatientViewModel patientView;

        protected override PatientViewModel getRandomObject()
        {
            return GetRandom.Object<PatientViewModel>();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new PatientViewModel());
        }

        [TestMethod]
        public void PatientIdTest()
        {

            string actual = getRandomObject().PatientId = "1asfpl6lüypkagrt";
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
        public void ProblemTest()
        {
            string expected = getRandomObject().PhoneNumber = "Head";
            Assert.AreEqual(expected, "Head");
        }

        [TestMethod]
        public void ProblemColorTest()
        {
            string expected = getRandomObject().ProblemColor = "red";
            Assert.AreEqual(expected, "red");
        }

        [TestMethod]
        public void ValidFromTest()
        {
            DateTime expected = getRandomObject().ValidFrom = DateTime.Today;
            Assert.AreEqual(expected, DateTime.Today);
        }

        [TestMethod]
        public void FormattedValidFromTest()
        {
            DateTime expected = getRandomObject().ValidFrom = DateTime.Today;
            Assert.AreEqual(expected, DateTime.Today);
        }

        [TestMethod]
        public void ValidToTest()
        {
            DateTime expected = getRandomObject().ValidTo = DateTime.MaxValue;
            Assert.AreEqual(expected, DateTime.MaxValue);
        }

        [TestMethod]
        public void FormattedValidToTest()
        {
            DateTime expected = getRandomObject().ValidFrom = DateTime.Today;
            Assert.AreEqual(expected, DateTime.Today);
        }
    }
}
