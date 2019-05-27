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
        private PatientDbRecord patient;

        [TestInitialize]
        public void Initialize()
        {
            patient = new PatientDbRecord();
        }

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
            string actual= patient.Id = "3asfpl5lüüpkadaf";
            Assert.AreEqual(actual, "3asfpl5lüüpkadaf");
        }
        [TestMethod]
        public void FirstNameTest()
        {
            string actual = patient.FirstName = "Jüri";
            Assert.AreEqual(actual, "Jüri");
        }

        public void FirstNameTooLongTest()
        {
            Assert.Inconclusive();
            //string actual = patient.FirstName = "Jüriookaoskdoafoasaghsuihdashfasihsaoifhiashfhasfiasjfasiasdh";
            //Assert.AreEqual(actual, "Jüriookaoskdoafoasaghsuihdashfasihsaoifhiashfhasfiasjfasiasdh");
        }
        [TestMethod]
        public void LastNameTest()
        {
            string expected = patient.FirstName = "Mets";
            Assert.AreEqual(expected, "Mets");
        }
        [TestMethod]
        public void IdCodeTest()
        {
            string expected = patient.IdCode= "39805225211";
            Assert.AreEqual(expected, "39805225211");
        }
        [TestMethod]
        public void ProblemTest()
        {
            string expected = patient.Problem = "Peavalu";
            Assert.AreEqual(expected, "Peavalu");
        }
        [TestMethod]
        public void PhoneNumberTest()
        {
            string expected = patient.PhoneNumber = "55587567";
            Assert.AreEqual(expected, "55587567");
        }
        [TestMethod]
        public void ValidFromTest()
        {
            DateTime expected = patient.ValidFrom = DateTime.Today;
            Assert.AreEqual(expected, DateTime.Today);
        }
        [TestMethod]
        public void ValidToTest()
        {
            DateTime expected = patient.ValidTo = DateTime.MaxValue;
            Assert.AreEqual(expected, DateTime.MaxValue);
        }


        //[Test]
        //public void TestId()
        //{
        //    int actual = patient.ID = 3;
        //    Assert.AreEqual(3, actual);
        //}
        //[Test]
        //public void TestGetId()
        //{
        //    int actual = patient1.ID;
        //    Assert.AreEqual(0, actual);
        //}

        //[Test]
        //public void TestLastName()
        //{
        //    string actual = patient.LastName = "Tamm";
        //    Assert.AreEqual("Tamm", actual);
        //}
        //[Test]
        //public void TestGetLastName()
        //{
        //    string actual = patient1.LastName;
        //    Assert.AreEqual(null, actual);
        //}

        //[Test]
        //public void TestFirstName()
        //{
        //    string actual = patient.FirstName = "Martin";
        //    Assert.AreEqual("Martin", actual);
        //}
        //[Test]
        //public void TestGetFirstName()
        //{
        //    string actual = patient1.FirstName;
        //    Assert.AreEqual(null, actual);
        //}

        //[Test]
        //public void TestInComingDate()
        //{
        //    DateTime starts = patient.InComingDate = DateTime.Parse("02-12-2019");
        //    Assert.AreEqual(DateTime.Parse("02-12-2019"), starts);
        //}
        //[Test]
        //public void TestGetInComingDate()
        //{
        //    DateTime starts = patient1.InComingDate;
        //    Assert.AreEqual(DateTime.Parse("01-01-0001"), starts);
        //}

        //[Test]
        //public void TestOutGoingDate()
        //{
        //    DateTime starts = patient.OutGoingDate = DateTime.Parse("03-12-2019");
        //    Assert.AreEqual(DateTime.Parse("03-12-2019"), starts);
        //}
        //[Test]
        //public void TestGetOutGoingDate()
        //{
        //    DateTime starts = patient1.OutGoingDate;
        //    Assert.AreEqual(DateTime.Parse("01-01-0001"), starts);
        //}

        //[Test]
        //public void TestSetPatientDepartment()
        //{
        //    patient1.Departments = new Department();
        //    Assert.IsNotNull(patient1.Departments);
        //}
        //[Test]
        //public void TestGetPatientDepartment()
        //{
        //    Department dep = patient.Departments;
        //    Assert.IsNull(dep);
        //}
    }
}
