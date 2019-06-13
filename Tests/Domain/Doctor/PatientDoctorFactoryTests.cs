using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Doctor;
using Open.Data.Patient;
using Open.Domain.Doctor;
using Open.Domain.Patient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Domain.Doctor
{
    [TestClass]
    public class PatientDoctorFactoryTests
    {
        private PatientDbRecord record;
        private PatientObject testPatient;
        private DoctorDbRecord r;
        private DoctorObject testDoctor;

        private DateTime validFrom;
        private DateTime validTo;
        private DoctorPatientIDbRecord rec;
        private PatientDoctorObject testPatientDoctor;
        private DateTime min;
        private DateTime max;

        [TestInitialize]
        public void initializeTestData()
        {
            min = DateTime.MinValue;
            max = DateTime.MaxValue;
            //testPatient = PatientObjectFactory();
            testPatient = PatientObjectFactory.Create("vlad", "jek", "39805225211", "Head", "55555555", min, max);
        }

        [TestMethod]
        public void DoesFactoryMethodWorkTest()
        {

            //testPatientDoctor = PatientDoctorObject.Create(testPatient, testDoctor, min, max);
            //Assert.IsNotNull(testPatient);

        }
    }
}
