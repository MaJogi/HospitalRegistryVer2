using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Doctor;
using System;
using System.Collections.Generic;
using System.Text;
using Open.Data.Patient;

namespace Open.Tests.Data.Doctors
{
    class DoctorPatientIDbRecordTests
    {
        [TestClass]
        public class DoctorDbRecordTests : ObjectTests<DoctorPatientIDbRecord>
        {
            private DoctorPatientIDbRecord doctorPatient;

            [TestInitialize]
            public void Initialize()
            {
                doctorPatient = new DoctorPatientIDbRecord();
            }

            protected override DoctorPatientIDbRecord getRandomObject()
            {
                return GetRandom.Object<DoctorPatientIDbRecord>();
            }

            [TestMethod]
            public override void CanCreateTest()
            {
                Assert.IsNotNull(obj);
            }

            [TestMethod]
            public void IdTest()
            {
                string actual = doctorPatient.Id = "3asfpl5lüüpkadfd";
                Assert.AreEqual(actual, "3asfpl5lüüpkadfd");
            }

            [TestMethod]
            public void PatientIdTest()
            {
                string actual = doctorPatient.PatientId = "4asfpl3lüüpkadfd";
                Assert.AreEqual(actual, "4asfpl3lüüpkadfd");
            }

            [TestMethod]
            public void DoctorIdTest()
            {
                string actual = doctorPatient.DoctorId = "1asfpl6lüypkagrt";
                Assert.AreEqual(actual, "1asfpl6lüypkagrt");
            }

            [TestMethod]
            public void DoctorTest()
            {
                doctorPatient.Doctor = new DoctorDbRecord();
                Assert.IsNotNull(doctorPatient.Doctor);
            }

            [TestMethod]
            public void PatientTest()
            {
                doctorPatient.Patient = new PatientDbRecord();
                Assert.IsNotNull(doctorPatient.Patient);
            }

            [TestMethod]
            public void ValidFromTest()
            {
                DateTime? expected = doctorPatient.ValidFrom = DateTime.Today;
                Assert.AreEqual(expected, DateTime.Today);
            }
            [TestMethod]
            public void ValidToTest()
            {
                DateTime? expected = doctorPatient.ValidTo = DateTime.MaxValue;
                Assert.AreEqual(expected, DateTime.MaxValue);
            }

           
        }
    }
}
