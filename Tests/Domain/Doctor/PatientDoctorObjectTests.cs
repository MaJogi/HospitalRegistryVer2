using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Doctor;
using Open.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Domain.Doctor
{
    [TestClass]
    public class PatientDoctorObjectTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new PatientDoctorObject(new DoctorPatientIDbRecord()));
        }
    }
}
