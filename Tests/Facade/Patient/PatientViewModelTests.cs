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

        //[TestMethod]
        //public void PatientIdTest()
        //{
        //    string actual = patientView.PatientId = "1asfpl6lüypkagrt";
        //    Assert.AreEqual(actual, "1asfpl6lüypkagrt");
        //}

        //[TestMethod]
        //public void FirstNameTest()
        //{
        //    string actual = patientView.FirstName = "Laura";
        //    Assert.AreEqual(actual, "Laura");
        //}

        //[TestMethod]
        //public void LastNameTest()
        //{
        //    string actual = patientView.LastName = "Haura";
        //    Assert.AreEqual(actual, "Haura");
        //}

        //[TestMethod]
        //public void IdCodeTest()
        //{
        //    string expected = patientView.IdCode = "39805345323";
        //    Assert.AreEqual(expected, "39805345323");
        //}

        //[TestMethod]
        //public void PhoneNumberTest()
        //{
        //    string expected = patientView.PhoneNumber = "53443532";
        //    Assert.AreEqual(expected, "53443532");
        //}

    }
}
