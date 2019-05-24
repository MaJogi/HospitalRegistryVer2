using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Patient;

namespace Open.Tests.Data.Patient
{
    [TestClass]
    public class PatientDbRecordTests : ObjectTests<PatientDbRecord>
    {
        protected override PatientDbRecord getRandomObject()
        {
            return GetRandom.Object<PatientDbRecord>();
        }

        [TestMethod]
        public override void CanCreateTest()
        {
            Assert.IsNotNull(obj); //was PatientDbRecord before
        }

        [TestMethod]
        public void IdTest()
        {
            Assert.Inconclusive();
        }
        public void FirstNameTest()
        {
            Assert.Inconclusive();
        }
        public void LastNameTest()
        {
            Assert.Inconclusive();
        }
        public void IdCodeTest()
        {
            Assert.Inconclusive();
        }
        public void ProblemTest()
        {
            Assert.Inconclusive();
        }
        public void PhoneNumberTest()
        {
            Assert.Inconclusive();
        }
        public void ValidFromTest()
        {
            Assert.Inconclusive();
        }
        public void ValidToTest()
        {
            Assert.Inconclusive();
        }

    }
}
