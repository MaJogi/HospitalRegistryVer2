using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Data.Doctor;
using Open.Domain.Doctor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open.Tests.Domain.Doctor
{
    [TestClass]
    public class DoctorObjectTests
    {
        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(new DoctorObject(new DoctorDbRecord()));
        }
    }
}
